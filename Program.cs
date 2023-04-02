using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.AddTheWorks(new StartupParametersBuilder()
    .WithThisAssemblyProject(typeof(ThisAssembly.Project))
    .WithAzureAppConfiguration(
        config => config.Connect(builder.Configuration["AZURE_APPCONFIGURATION_CONNECTION_STRING"]),
        config => config.SetCredential(AddAzureAppConfigExtensions.DefaultKeyVaultCredentialsFactory(builder.Configuration)))
    .WithHealthChecks(_ => { })
    .Build());

var app = builder.Build();

app.UseTheWorks(typeof(ThisAssembly.Project));

app.Run();
