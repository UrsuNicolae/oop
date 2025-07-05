using Moq;
using System.Threading.Tasks;
using TestingProject.UTs;

namespace TestProject1
{
    public class WeatherAnalyzerTests
    {
        [Theory]
        [InlineData("chisinau", 30, "Hot")]
        [InlineData("straseni",  15, "Moderate")]
        [InlineData("bucuresti", 40, "Hot")]
        [InlineData("cahul", 9, "Cold")]
        public async Task AnalyzeWeatherShouldReturnValidCategoryPerTemperature(string city, int temperature, string type)
        {
            var weatherService = new Mock<IWeatherService>();
            weatherService.Setup(_ => _.GetTemperature(city))
                .ReturnsAsync(temperature);

            var wetherAnalyzer = new WeatherAnalyzer(weatherService.Object);
            var temperatureType = await wetherAnalyzer.AnalyzeWeather(city);

            Assert.Equal(type, temperatureType);
        }

        [Theory]
        [InlineData("chisinau", 30, "Hot")]
        [InlineData("straseni", 15, "Moderate")]
        [InlineData("bucuresti", 40, "Hot")]
        [InlineData("cahul", 9, "Cold")]
        [InlineData("cahul", -1, "Freezing")]
        public async Task AnalyzeWeatherShouldInvokeGetTemperatureExaclyOnce(string city, int temperature, string type)
        {
            var weatherService = new Mock<IWeatherService>();
            weatherService.Setup(_ => _.GetTemperature(city))
                .ReturnsAsync(temperature);

            var wetherAnalyzer = new WeatherAnalyzer(weatherService.Object);
            var temperatureType = await wetherAnalyzer.AnalyzeWeather(city);

            Assert.Equal(type, temperatureType);
            weatherService.Verify(_ => _.GetTemperature(city), Times.Once);
        }


    }
}
