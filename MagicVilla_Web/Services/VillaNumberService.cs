
namespace MagicVilla_Web.Services
{
    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly IHttpClientFactory _httpClient;

        private readonly string _villaUrl;

        public VillaNumberService(IHttpClientFactory httpClient, IConfiguration configuration) : base(httpClient)
        {
            _httpClient = httpClient;
            _villaUrl = configuration.GetValue<string>("ServiceUrls:villaAPI")!;

        }

        public Task<T> GetAllAsync<T>() => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.GET,
            Url = $"{_villaUrl}/api/villaNumberAPI"
        });

        public Task<T> GetAsync<T>(int VillaNo) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.GET,
            Url = $"{_villaUrl}/api/villaNumberAPI/{VillaNo}"
        });

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.POST,
            Data = dto,
            Url = $"{_villaUrl}/api/villaNumberAPI"
        });

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.PUT,
            Data = dto,
            Url = $"{_villaUrl}/api/villaNumberAPI/{dto.VillaNo}"
        });

        public Task<T> DeleteAsync<T>(int VillaNo) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiType.DELETE,
            Url = $"{_villaUrl}/api/villaNumberAPI/{VillaNo}"
        });
    }
}
