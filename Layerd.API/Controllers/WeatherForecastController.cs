using Layerd.Domain.Interfaces;
using Layerd.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Layerd.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _service;
        private readonly IWeatherForecastRepository _repo;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service, IWeatherForecastRepository repo)
        {
            _service = service;
            _repo = repo;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _service.ProcessTemperature();
        }
    }
}