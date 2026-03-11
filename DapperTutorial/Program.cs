using Microsoft.Extensions.Configuration;

var environmentName = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Production";

var configuration = new ConfigurationBuilder()
	.SetBasePath(AppContext.BaseDirectory)
	.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
	.AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: false)
	.AddEnvironmentVariables()
	.Build();



