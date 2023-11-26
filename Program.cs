using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Dgmjr.InsultGenerator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.AddTheWorks(
    builder =>
        builder
            .WithThisAssemblyProject(typeof(ThisAssembly.Project))
            // .AddDbContext<InsultsDbContext>(ServiceLifetime.Transient, ServiceLifetime.Transient)
            .WithAzureAppConfig(false)
            .WithSwagger(true)
            .WithHashids(true)
            .WithJsonPatch(true)
            .WithAppInsights(true)
            .WithHealthChecks(hcb => hcb.AddDbContextCheck<InsultsDbContext>())
            .AddDbContext<InsultsDbContext>(opts => opts.UseInMemoryDatabase("InsultsDb"))
            // config =>
            //     config.Connect(builder.Configuration["AZURE_APPCONFIGURATION_CONNECTION_STRING"]),
            // config =>
            //     config.SetCredential(
            //         AddAzureAppConfigExtensions.DefaultKeyVaultCredentialsFactory(
            //             builder.Configuration
            //         )
            //     )
            // )
            // .WithHealthChecks(_ => { })
            .Build()
);

var app = builder.Build();

app.UseTheWorks();

app.Run();
