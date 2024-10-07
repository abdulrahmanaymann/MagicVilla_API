using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace MagicVilla_VillaAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        private readonly string _key;

        public UserRepository(ApplicationDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _key = configuration.GetValue<string>("APISettings:Secret")!;
        }

        public bool IsUniqueUser(string username)
        {
            var user = _context.localUsers.FirstOrDefault(x => x.Username == username);
            return user == null;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO dto)
        {
            var user = await _context.localUsers
                .FirstOrDefaultAsync(x => x.Username.ToLower() == dto.Username.ToLower()
                && x.Password == dto.Password);

            if (user == null)
            {
                return new LoginResponseDTO()
                {
                    Token = string.Empty,
                    User = new LocalUser()
                };
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            LoginResponseDTO response = new LoginResponseDTO
            {
                User = user,
                Token = tokenHandler.WriteToken(token)
            };

            return response;
        }

        public async Task<LocalUser> Register(RegisterationRequestDTO dto)
        {
            LocalUser user = _mapper.Map<LocalUser>(dto);

            await _context.localUsers.AddAsync(user);
            await _context.SaveChangesAsync();
            user.Password = "";
            return user;
        }
    }
}
