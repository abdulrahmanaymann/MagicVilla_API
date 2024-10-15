using MagicVilla.Models.Models.DTOs.AuthDTOs;
using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;
using static MagicVilla_Utility.SD;

namespace MagicVilla_Web.Services
{
    public class AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : BaseService(clientFactory), IAuthService
    {
        private readonly string _villaUrl = configuration.GetValue<string>("ServiceUrls:villaAPI")!;

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