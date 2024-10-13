namespace MagicVilla_Web.Services
{
    public class VillaService(IHttpClientFactory httpClient, IConfiguration configuration) : BaseService(httpClient), IVillaService
    {
        private readonly IHttpClientFactory _httpClient = httpClient;

        private readonly string _villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI")!;

        public Task<T> GetAllAsync<T>(string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.GET,
            Url = $"{_villaUrl}/api/v1/villaAPI",
            Token = token
        });

        public Task<T> GetAsync<T>(int id, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.GET,
            Url = $"{_villaUrl}/api/v1/villaAPI/{id}",
            Token = token
        });

        public Task<T> CreateAsync<T>(VillaCreateDTO dto, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.POST,
            Data = dto,
            Url = $"{_villaUrl}/api/v1/villaAPI",
            Token = token
        });

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.PUT,
            Data = dto,
            Url = $"{_villaUrl}/api/v1/villaAPI/{dto.Id}",
            Token = token
        });

        public Task<T> DeleteAsync<T>(int id, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.DELETE,
            Url = $"{_villaUrl}/api/v1/villaAPI/{id}",
            Token = token
        });
    }
}
