namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get; set; }

        private readonly IHttpClientFactory _httpClient;

        public BaseService(IHttpClientFactory httpClient)
        {
            responseModel = new APIResponse();
            _httpClient = httpClient;
        }

        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = _httpClient.CreateClient("MagicVillaAPI");
                HttpRequestMessage message = new();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                if (apiRequest != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
                        Encoding.UTF8, "application/json");
                }

                message.Method = apiRequest.ApiType switch
                {
                    ApiType.GET => HttpMethod.Get,
                    ApiType.POST => HttpMethod.Post,
                    ApiType.PUT => HttpMethod.Put,
                    ApiType.DELETE => HttpMethod.Delete,
                    _ => HttpMethod.Get,
                };

                HttpResponseMessage? apiResponse = null;

                apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseObj = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseObj;
            }

            catch (Exception ex)
            {
                var dto = new APIResponse
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    IsSuccess = false,
                    ErrorMessages = [ex.Message],
                };

                var res = JsonConvert.SerializeObject(dto);
                var apiResponseObj = JsonConvert.DeserializeObject<T>(res);
                return apiResponseObj;
            }
        }
    }
}
