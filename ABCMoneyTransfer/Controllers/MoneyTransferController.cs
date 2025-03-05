using ABC.Application.Services;
using ABC.Application.ViewModel;
using ABC.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ABCMoneyTransfer.Controllers
{
    public class MoneyTransferController : Controller
    {
        private readonly IMoneyTransferService _moneyTransferService;

        public MoneyTransferController(IMoneyTransferService moneyTransferService)
        {
            _moneyTransferService = moneyTransferService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MoneyTransfer()
        {
            var model = new MoneyTransferViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MoneyTransfer(MoneyTransferViewModel model)
        {
            try
            {
                var savedModel = await _moneyTransferService.SendMoney(model);
                return View(savedModel);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
