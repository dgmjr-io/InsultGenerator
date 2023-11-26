namespace Dgmjr.WetherForecast.Models;

using Dgmjr.WetherForecast.Models.Abstractions;

public class WeatherForecast
{
    public date Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public ISummary? Summary { get; set; }

    public ICloudCover CloudCover { get; set; }

    public IPrecipitation Precipitation { get; set; }
}
