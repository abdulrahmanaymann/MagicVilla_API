namespace MagicVilla_Web.Services
{
    public class AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : BaseService(clientFactory), IAuthService
    {
        private readonly string _villaUrl = configuration.GetValue<string>("ServiceUrls:villaAPI")!;

        public Task<T> LoginAsync<T>(LoginRequestDTO dto) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.POST,
            Data = dto,
            Url = $"{_villaUrl}/api/v1/UserAuth/login"
        });

        public Task<T> RegisterAsync<T>(RegisterationRequestDTO dto) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.POST,
            Data = dto,
            Url = $"{_villaUrl}/api/v1/UserAuth/register"
        });
    }
}