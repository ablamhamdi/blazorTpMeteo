using AppMeteo.Shared;
using AppMeteo.Shared.Data;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace AppMeteo.Client.Pages
{
    public partial class FetchData
    {
        [Inject]
        public WeatherForecastService weather { get; set; }
        private WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await weather.GetForecastAsync(DateTime.Now);
        }
    }
}
