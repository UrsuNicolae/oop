namespace TestingProject.UTs
{
    public interface IWeatherService
    {
        Task<decimal> GetTemperature(string city);
    }


    public class WeatherAnalyzer
    {
        private IWeatherService _weatherService;


        public WeatherAnalyzer(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }


        public async Task<string> AnalyzeWeather(string city)
        {
            var temperature = await _weatherService.GetTemperature(city);
            if(temperature < 0)
            {
                return "Freezing";
            }
            if (temperature < 10)
            {
                return "Cold";
            }
            else if (temperature < 25)
            {
                return "Moderate";
            }
            else
            {
                return "Hot";   
            }
        }
    }

}
