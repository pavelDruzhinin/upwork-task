using System.Threading.Tasks;
using Quartz;
using UpworkTask.Console.Services;

namespace UpworkTask.Console.Jobs
{
    public class LoggingJob : IJob
    {
        private readonly LoggingService _loggingService;

        public LoggingJob(LoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _loggingService.Run();

            return Task.FromResult(0);
        }
    }
}
