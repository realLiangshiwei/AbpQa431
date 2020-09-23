using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Volo.Abp.Application.Services;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;

namespace Qa431
{
    public class DemoAppService : ApplicationService
    {
        private readonly IBackgroundJobManager _backgroundJobManager;

        public DemoAppService(IBackgroundJobManager backgroundJobManager)
        {
            _backgroundJobManager = backgroundJobManager;
        }

        public async Task Test()
        {
             await _backgroundJobManager.EnqueueAsync(new JobQueue1Args());
             await _backgroundJobManager.EnqueueAsync(new JobQueue2Args());
        }
    }


    public class Queue1Job : BackgroundJob<JobQueue1Args> , ITransientDependency
    {
        public override void Execute(JobQueue1Args args)
        {
            Logger.LogInformation(args.Queue);
        }
    }

    public class Queue2Job : BackgroundJob<JobQueue2Args> , ITransientDependency
    {
        public override void Execute(JobQueue2Args args)
        {
            Logger.LogInformation(args.Queue);
        }
    }

    public class JobQueue1Args : ISpecifiedQueueJob
    {
        public string Queue { get; set; } = "queue1";

        public string Name { get; set; }
    }

    public class JobQueue2Args : ISpecifiedQueueJob
    {
        public string Queue { get; set; } = "queue2";

        public string Name { get; set; }
    }
}
