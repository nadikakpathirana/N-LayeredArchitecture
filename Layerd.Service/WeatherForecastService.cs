using Layerd.Domain.Interfaces;
using Layerd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layerd.Service
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repo;

        public WeatherForecastService(IWeatherForecastRepository repo)
        {
            _repo = repo;
        }

        public List<WeatherForecast> ProcessTemperature()
        {
            var forecasts = _repo.GetForecast();
            var processed = new List<WeatherForecast>();

            foreach (var forecast in forecasts)
            {
                forecast.TemperatureF = 32 + (int)(forecast.TemperatureC / 0.5556);
                processed.Add(forecast);
            }
            return processed;
        }
    }
}
