using ABC.Client.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Client.Interfaces
{
    public interface IExchangeRateApiClient
    {
        Task<ApiResponse> GetExchangeRatesAsync(DateTime from, DateTime to, int skip = 0, int take = 5);
    }
}
