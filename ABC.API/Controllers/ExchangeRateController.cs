using Microsoft.AspNetCore.Mvc;

namespace ABC.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ExchangeRateController : ControllerBase
{

    private readonly ILogger<ExchangeRateController> _logger;

    public ExchangeRateController(ILogger<ExchangeRateController> logger)
    {
        _logger = logger;
    }

    //public IActionResult Get()
    //{
        
    //}
}
