using System.Collections.Specialized;
using System.Threading.Tasks;
using Quartz.Impl;
using UpworkTask.Console.Jobs;

namespace UpworkTask.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = ServiceProviderFactory.Create();

            var jobFactory = new JobFactory(serviceProvider);
            var properties = new NameValueCollection
            {
                
            };
            var schedulerFactory = new StdSchedulerFactory(properties);
            var scheduler = await schedulerFactory.GetScheduler();

            scheduler.JobFactory = jobFactory;

            await scheduler.Start();
        }
    }
}
