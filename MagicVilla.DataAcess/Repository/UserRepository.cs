using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using MagicVilla.DataAcess.Data;
using MagicVilla.Models.Models;
using MagicVilla.Models.Models.DTOs.AuthDTOs;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace MagicVilla_VillaAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly string _key;

        public UserRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IMapper mapper, IConfiguration configuration, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
            _key = configuration["APISettings:Secret"]!;
        }

        public bool IsUniqueUser(string UserName)
        {
            var user = _context.ApplicationUsers.FirstOrDefault(x => x.UserName == UserName);
            return user == null;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO dto)
        {
            var user = await _context.ApplicationUsers
                .FirstOrDefaultAsync(x => (x.UserName.ToLower()).Equals(dto.UserName.ToLower()));

            bool isValid = await _userManager.CheckPasswordAsync(user, dto.Password);

            if (user == null || isValid == false)
            {
                return new LoginResponseDTO()
                {
                    Token = string.Empty,
                    User = null,
                };
            }

            var roles = await _userManager.GetRolesAsync(user);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                [
                    new Claim(ClaimTypes.Name, user.UserName.ToString()),
                    new Claim(ClaimTypes.Role,roles.FirstOrDefault())
                ]),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            LoginResponseDTO response = new()
            {
                User = _mapper.Map<UserDTO>(user),
                Token = tokenHandler.WriteToken(token)
            };

            return response;
        }

        public async Task<UserDTO> Register(RegisterationRequestDTO dto)
        {
            ApplicationUser user = new()
            {
                UserName = dto.UserName,
                Name = dto.Name,
                Email = dto.UserName,
                NormalizedEmail = dto.UserName.ToUpper(),
            };

            try
            {
                var result = await _userManager.CreateAsync(user, dto.Password);
                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Admin"));
                        await _roleManager.CreateAsync(new IdentityRole("User"));
                    }

                    await _userManager.AddToRoleAsync(user, "Admin");
                    var userToReturn = _context.ApplicationUsers
                        .FirstOrDefault(x => x.UserName == dto.UserName);

                    return _mapper.Map<UserDTO>(userToReturn);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new UserDTO();
        }
    }
}
