using Microsoft.AspNetCore.Mvc;

namespace ABCMoneyTransfer.Controllers
{
    public class MoneyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
