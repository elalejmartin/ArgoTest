using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Xml.Linq;

namespace Microservices1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration; 
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            string baseUrl = _configuration["ApiSettings:BaseUrl"];

            using var httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };

            var response = await httpClient.GetAsync("/WeatherForecast");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                return Ok(json);

            }

            return NoContent();
        }
    }
}
