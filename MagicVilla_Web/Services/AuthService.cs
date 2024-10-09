namespace MagicVilla_Web.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string _villaUrl;

        public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            _villaUrl = configuration.GetValue<string>("ServiceUrls:villaAPI")!;
        }

        public Task<T> LoginAsync<T>(LoginRequestDTO dto) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.POST,
            Data = dto,
            Url = $"{_villaUrl}/api/UserAuth/login"
        });

        public Task<T> RegisterAsync<T>(RegisterationRequestDTO dto) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.POST,
            Data = dto,
            Url = $"{_villaUrl}/api/UserAuth/register"
        });
    }
}