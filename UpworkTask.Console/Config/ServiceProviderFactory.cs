using Microsoft.Extensions.DependencyInjection;
using Serilog;
using UpworkTask.Console.Services;
using UpworkTask.ConsoleApp;
using Microsoft.Extensions.Configuration;

namespace UpworkTask.Console
{
    internal static class ServiceProviderFactory
    {
        public static ServiceProvider Create()
        {
            var configuration = ConfigurationFactory.Create();

            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            var services = new ServiceCollection();

            services.AddSingleton<ILogger>(logger);

            services.AddScoped<LoggingService>();

            return services.BuildServiceProvider();
        }
    }
}