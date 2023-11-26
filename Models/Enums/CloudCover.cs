namespace Dgmjr.WetherForecast.Enums;

[GenerateEnumerationRecordClass(nameof(CloudCover), "Dgmjr.WetherForecast.Models")]
public enum CloudCover
{
    [Display(Name = "Clear 🌞", ShortName = "Clear")]
    Clear,

    [Display(Name = "Partly Cloudy 🌤", ShortName = "Partly Cloudy")]
    PartlyCloudy,

    [Display(Name = "Cloudy 🌥", ShortName = "Cloudy")]
    Cloudy,

    [Display(Name = "Overcast 🌧", ShortName = "Overcast")]
    Overcast
}
