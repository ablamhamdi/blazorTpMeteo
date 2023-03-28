using Microsoft.AspNetCore.Components;

namespace AppMeteo.Shared.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] summaries = new[]
                 {
                //"Freezing", "Bracing", "Chilly", "Cool", "Mild", 
                //"Warm", "Balmy", "Hot", "Sweltering", "Scorching"
                "Cloudy", "Rainy", "Sunny"
                };
        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
           // var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            return await Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = summaries[rng.Next(summaries.Length)]
            }).ToArray());
        }

    }
}
