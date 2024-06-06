using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Extensions.Logging;

namespace BackgroundJobTask.BackgroundJob
{
    public class ScheduledJobWorker
    {
        private readonly ILogger<ScheduledJobWorker> _logger;

        public ScheduledJobWorker(ILogger<ScheduledJobWorker> logger)
        {
            _logger = logger;
        }

        public async Task ExecuteAsync()
        {
            _logger.LogInformation("Executing ScheduledJobWorker..!");
            
            await Task.CompletedTask;
        }

        public void ScheduleJobs()
        {
            var options = new RecurringJobOptions
            {
                TimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time")
            };

            RecurringJob.AddOrUpdate<ScheduledJobWorker>(
                "scheduled-job",
                job => job.ExecuteAsync(),
                "57 15 * * *", // 3:57 PM IST
                options
            );

            _logger.LogInformation("Scheduled job 'scheduled-job' successfully!");
        }



    }
}
