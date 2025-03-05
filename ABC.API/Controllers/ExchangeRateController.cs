using ABC.API.Interfaces;
using ABC.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

[ApiController]
[Route("api/exchangeRates")]
public class ExchangeRateController : ControllerBase
{
    private readonly IExchangeRateService _exchangeRateService;

    public ExchangeRateController(IExchangeRateService exchangeRateService)
    {
        _exchangeRateService = exchangeRateService;
    }

    [HttpGet("getExchangeRates")]
    public async Task<IActionResult> Get([FromQuery] DateTime fromDate, [FromQuery] DateTime toDate, [FromQuery] int skip = 0, [FromQuery] int take = 5)
    {
        try
        {
            var response = await _exchangeRateService.GetExchangeRatesAsync(skip, take, fromDate, toDate);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(new ApiResponse(null, 0, ex.Message, 400));
        }
    }
}