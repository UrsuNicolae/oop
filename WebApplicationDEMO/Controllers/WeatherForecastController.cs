using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDEMO.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly List<string> Summaries = new()
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        var index = 0;
        return Summaries.Select(weather =>
        {
            var res = new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = weather
            };
            index++;
            return res;
        });
    }



    [HttpPost]
    public IActionResult Add(string weather)
    {
        if (Summaries.Contains(weather))
        {
            return Ok("Created");
        }
        Summaries.Add(weather);
        return Ok(weather);
    }

    [HttpDelete("{weather}")]
    public IActionResult Delete(string weather)
    {
        if (!Summaries.Contains(weather))
        {
            return NotFound($"Wether {weather} not found!");
        }
        Summaries.Remove(weather);
        return Ok();
    }

    [HttpGet("{weather}")]
    public IActionResult Get(string weather)
    {
        if (!Summaries.Contains(weather))
        {
            return NotFound($"Wether {weather} not found!");
        }
        var index = 0;
        var summaries = Summaries.Select(weather =>
        {
            var res = new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = weather
            };
            index++;
            return res;
        });
        return Ok(summaries.FirstOrDefault(s => s.Summary == weather));
    }
}
