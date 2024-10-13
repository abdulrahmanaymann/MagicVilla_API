
namespace MagicVilla_Web.Services
{
    public class VillaNumberService(IHttpClientFactory httpClient, IConfiguration configuration) : BaseService(httpClient), IVillaNumberService
    {
        private readonly IHttpClientFactory _httpClient = httpClient;

        private readonly string _villaUrl = configuration.GetValue<string>("ServiceUrls:villaAPI")!;

        public Task<T> GetAllAsync<T>(string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.GET,
            Url = $"{_villaUrl}/api/v1/villaNumberAPI",
            Token = token
        });

        public Task<T> GetAsync<T>(int VillaNo, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.GET,
            Url = $"{_villaUrl}/api/v1/villaNumberAPI/{VillaNo}",
            Token = token
        });

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.POST,
            Data = dto,
            Url = $"{_villaUrl}/api/v1/villaNumberAPI",
            Token = token
        });

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.PUT,
            Data = dto,
            Url = $"{_villaUrl}/api/v1/villaNumberAPI/{dto.VillaNo}",
            Token = token
        });

        public Task<T> DeleteAsync<T>(int VillaNo, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.DELETE,
            Url = $"{_villaUrl}/api/v1/villaNumberAPI/{VillaNo}",
            Token = token
        });
    }
}
