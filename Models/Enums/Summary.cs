namespace Dgmjr.WetherForecast.Enums;

[GenerateEnumerationRecordStruct(nameof(Summary), "Dgmjr.WetherForecast.Models")]
public enum Summary
{
    [Display(Name = "Freezing 🥶", ShortName = "Freezing")]
    Freezing,

    [Display(Name = "Bracing 😳", ShortName = "Bracing")]
    Bracing,

    [Display(Name = "Chilly 🥶", ShortName = "Chilly")]
    Chilly,

    [Display(Name = "Cool 😎", ShortName = "Cool")]
    Cool,

    [Display(Name = "Mild 😐", ShortName = "Mild")]
    Mild,

    [Display(Name = "Warm 🥵", ShortName = "Warm")]
    Warm,

    [Display(Name = "Balmy 🥵", ShortName = "Balmy")]
    Balmy,

    [Display(Name = "Hot 🥵", ShortName ="Hot")]
    Hot,

    [Display(Name = "Sweltering 🥵", ShortName ="Sweltering")]
    Sweltering,

    [Display(Name = "Scorching 🥵", ShortName = "Scorching")]
    Scorching
}



