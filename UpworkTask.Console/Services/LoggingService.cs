using System;
using Serilog;

namespace UpworkTask.Console.Services
{
    public class LoggingService
    {
        private readonly ILogger _logger;

        public LoggingService(ILogger logger)
        {
            _logger = logger;
        }

        internal void Run()
        {
            throw new NotImplementedException();
        }
    }
}
