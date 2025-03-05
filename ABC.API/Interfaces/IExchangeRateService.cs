using ABC.API.Models;

namespace ABC.API.Interfaces
{
    public interface IExchangeRateService
    {
        Task<ApiResponse> GetExchangeRatesAsync(int skip, int take, DateTime fromDate, DateTime toDate);
    }
}
