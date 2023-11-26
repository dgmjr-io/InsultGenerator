namespace Dgmjr.WetherForecast.Enums;

[GenerateEnumerationRecordStruct(nameof(Precipitation), "Dgmjr.WetherForecast.Models")]
public enum Precipitation
{
    [Display(Name = "None 🌞", ShortName = "None")]
    None,

    [Display(Name = "Drizzle 🌧", ShortName = "Drizzle")]
    Drizzle,

    [Display(Name = "Rain 🌧", ShortName = "Rain")]
    Rain,

    [Display(Name = "Snow ❄️", ShortName = "Snow")]
    Snow,

    [Display(Name = "Sleet 🌨", ShortName = "Sleet")]
    Sleet,

    [Display(Name = "Hail 🌨", ShortName = "Hail")]
    Hail,

    [Display(Name = "Thunderstorms ⛈️", ShortName = "Thunderstorms")]
    Thunderstorms
}
