namespace MagicVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _httpClient;

        private readonly string _villaUrl;

        public VillaService(IHttpClientFactory httpClient, IConfiguration configuration) : base(httpClient)
        {
            _httpClient = httpClient;
            _villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI")!;

        }

        public Task<T> GetAllAsync<T>() => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.GET,
            Url = $"{_villaUrl}/api/villaAPI"
        });

        public Task<T> GetAsync<T>(int id) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.GET,
            Url = $"{_villaUrl}/api/villaAPI/{id}"
        });

        public Task<T> CreateAsync<T>(VillaCreateDTO dto) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.POST,
            Data = dto,
            Url = $"{_villaUrl}/api/villaAPI"
        });

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.PUT,
            Data = dto,
            Url = $"{_villaUrl}/api/villaAPI/{dto.Id}"
        });

        public Task<T> DeleteAsync<T>(int id) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.DELETE,
            Url = $"{_villaUrl}/api/villaAPI/{id}"
        });
    }
}
