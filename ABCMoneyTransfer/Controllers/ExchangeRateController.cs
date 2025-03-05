using ABC.Client.APIClients;
using ABC.Client.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ABCMoneyTransfer.Controllers
{
    public class ExchangeRateController : Controller
    {
        private readonly ExchangeRateApiClient _exchangeRateApiClient;

        public ExchangeRateController(ExchangeRateApiClient exchangeRateApiClient)
        {
            _exchangeRateApiClient = exchangeRateApiClient;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); 
        }
        [HttpGet]
        public IActionResult ViewExchangeRates()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetExchangeReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                var apiResponse = await _exchangeRateApiClient.GetExchangeRatesAsync(fromDate, toDate);

                if (apiResponse != null && apiResponse.Success)
                {
                    return Json(new
                    {
                        data = apiResponse.Data
                    });
                }

                return Json(new { data = new object[] { } });
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}