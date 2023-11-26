// namespace Dgmjr.WetherForecast.Controllers;

// using Microsoft.AspNetCore.Mvc;
// using Dgmjr.AspNetCore.Mvc;
// using Dgmjr.WetherForecast.Models.Abstractions;
// using Dgmjr.WetherForecast.Models;

// [ApiController]
// [Route("[controller]")]
// public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase
// {
//     public static ISummary[] Summaries => Summary.GetAll().ToArray();
//     public static ICloudCover[] CloudCovers => CloudCover.GetAll().ToArray();
//     public static IPrecipitation[] Precipitations => Precipitation.GetAll().ToArray();

//     public ILogger Logger { get; } = logger;

//     [HttpGet(Name = "GetWeatherForecast")]
//     [
//         ProducesOKResponse<Pager<WeatherForecast>>,
//         Produces400Error,
//         Produces500Error,
//         Produces404Error
//     ]
//     public Pager<WeatherForecast> Get()
//     {
//         return new Pager<WeatherForecast>(
//             Enumerable
//                 .Range(1, 5)
//                 .Select(
//                     index =>
//                         new WeatherForecast
//                         {
//                             Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//                             TemperatureC = Random.Shared.Next(-20, 55),
//                             Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//                         }
//                 )
//                 .ToArray(),
//             1,
//             5,
//             5
//         );
//     }

//     [HttpGet]
//     [Produces404Error]
//     public NotFoundProblemDetails YouDumbFuck()
//     {
//         return new NotFoundProblemDetails();
//     }
// }
