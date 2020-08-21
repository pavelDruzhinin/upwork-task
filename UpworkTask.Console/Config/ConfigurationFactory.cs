using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace UpworkTask.ConsoleApp
{
    internal static class ConfigurationFactory
    {
        public static IConfiguration Create()
        {
            var environmentName = Environment.GetEnvironmentVariable("RUNTIME_ENVIRONMENT");
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json",
                    reloadOnChange: true,
                    optional: true)
                .Build();
        }
    }
}