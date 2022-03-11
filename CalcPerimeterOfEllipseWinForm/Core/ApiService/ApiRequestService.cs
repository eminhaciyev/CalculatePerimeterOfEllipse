using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CalcPerimeterOfEllipseWinForm.Core.ApiService
{
    public class ApiRequestService
    {
        private readonly ApiRequestOptions _options;

        public ApiRequestService(ApiRequestOptions options) => _options = options ?? new ApiRequestOptions();

        //Request url and response Deserialize object
        public async Task<TResponse> GetAsync<TResponse>(string url, Action<ApiRequestOptions> apiOptions = default)
        {
            try
            {

                return await ApiRequest(async (httpClient) =>
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    return JsonConvert.DeserializeObject<TResponse>(await response.Content.ReadAsStringAsync());
                }, apiOptions);
            }
            catch
            {
                throw new ApiRequestException($"{_options.BaseAddress}{url}");
            }
        }


        protected async Task<TResponse> ApiRequest<TResponse>(Func<HttpClient, Task<TResponse>> func, Action<ApiRequestOptions> apiOptions = default)
        {
            apiOptions?.Invoke(_options);

            HttpClient httpClient = new HttpClient(new HttpClientHandler()
            {
                UseDefaultCredentials = _options.UseDefaultCredentials
            });


            httpClient.BaseAddress = _options.BaseAddress;

            foreach (var header in _options.Headers)
                httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);

            return await func(httpClient);
        }
    }
}
