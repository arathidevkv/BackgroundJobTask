using System.Threading;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Extensions.Logging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;

namespace BackgroundJobTask.BackgroundJob
{
    public class ScheduleTask : HangfireBackgroundWorkerBase
    {
        public string RecurringJobId { get; }
        public string CronExpression { get; }

        public ScheduleTask(ILogger<ScheduleTask> logger) : base(logger)
        {
            RecurringJobId = nameof(ScheduleTask);
            CronExpression = Cron.Daily();
        }

        public override Task DoWorkAsync(CancellationToken cancellationToken = default)
        {
            Logger.LogInformation("Executing MyLogWorker..!");
            return Task.CompletedTask;
        }

        
        public override void Execute(ScheduleTask args)
        {
            DoWorkAsync().Wait(); 
        }
    }

    public abstract class HangfireBackgroundWorkerBase : BackgroundJob<ScheduleTask>
    {
        protected ILogger Logger { get; }

        protected HangfireBackgroundWorkerBase(ILogger logger)
        {
            Logger = logger;
        }

        public abstract Task DoWorkAsync(CancellationToken cancellationToken = default);
    }
}
