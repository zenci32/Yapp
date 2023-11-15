using BusinessLayer.CurlServices;
using CurlServices;
using Microsoft.AspNetCore.Mvc;

namespace Yapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICurlService _curlService; 

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICurlService curlService)
        {
            _logger = logger;
            _curlService = curlService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Login()
        {
            var result = await _curlService.Login2();

            return Ok(result);

        }
    }
}