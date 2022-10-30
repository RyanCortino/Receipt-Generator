using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReceiptGenerator.ConsoleUi.Services;
using ReceiptGenerator.Domain.Common.Interfaces;
using Serilog;

// Setting up the configuartion for serilog 
ConfigurationBuilder builder = new();
BuildConfig(builder);

// Setting up the logger 
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Build())
    .Enrich.FromLogContext()
    .WriteTo.Console(outputTemplate: "{Message:lj}{NewLine}{Exception}")
    .CreateLogger();

// Setting up dependency injection
IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddTransient<IEntryService, Demonstration>();
        services.AddTransient<ICartService, CartService>();
    })
    .UseSerilog()
    .Build();

var svc = ActivatorUtilities.CreateInstance<Demonstration>(host.Services, args);
svc.Run(args);

static void BuildConfig(IConfigurationBuilder builder)
{
    builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Productions"}.json", optional: true)
        .AddEnvironmentVariables();
}