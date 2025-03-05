using ABC.API.Interfaces;
using ABC.API.Models;
using Newtonsoft.Json;

namespace ABC.API.Services
{
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly HttpClient _httpClient;

        public ExchangeRateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ApiResponse> GetExchangeRatesAsync(int skip, int take, DateTime fromDate, DateTime toDate)
        {
            string fromDateString = fromDate.ToString("yyyy-MM-dd");
            string toDateString = toDate.ToString("yyyy-MM-dd");

            var endpoint = $"https://www.nrb.org.np/api/forex/v1/rates?page={skip + 1}&per_page={take}&from={fromDateString}&to={toDateString}";

            var response = await _httpClient.GetStringAsync(endpoint);
            var exchangeRateResponse = JsonConvert.DeserializeObject<ExchangeRateResponse>(response);

            if (exchangeRateResponse == null || !exchangeRateResponse.Data.Payload.Any())
            {
                return new ApiResponse(string.Empty, 0, "No currency data found for the given date range.", 200);
            }

            string dataAsString = JsonConvert.SerializeObject(exchangeRateResponse);

            return new ApiResponse(dataAsString, exchangeRateResponse.Data.Payload.FirstOrDefault().Rates.Count);
        }
    }
}
