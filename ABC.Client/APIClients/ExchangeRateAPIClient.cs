using ABC.Client.APIModels;
using ABC.Client.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Client.APIClients
{
    public class ExchangeRateApiClient : IExchangeRateApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ExchangeRateApiClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["ApiBaseUrl"];
        }

        public async Task<ApiResponse> GetExchangeRatesAsync(DateTime from, DateTime to, int skip = 0, int take = 5)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/api/exchangeRates/getExchangeRates?fromDate={from:yyyy-MM-dd}&toDate={to:yyyy-MM-dd}&skip={skip}&take={take}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse>(content);
            }

            return new ApiResponse(null, "Error fetching exchange rates", (int)response.StatusCode);
        }
    }
}
