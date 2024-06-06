using System;
using BackgroundJobTask.BackgroundJob;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Volo.Abp.BackgroundJobs;

namespace BackgroundJobTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly ILogger<JobController> _logger;

        public JobController(ILogger<JobController> logger)
        {
            _logger = logger;
        }

        [HttpPost("schedule")]
        public IActionResult ScheduleJob()
        {
            RecurringJob.AddOrUpdate<ScheduleTask>(
                x => x.DoWorkAsync(default),
                Cron.Daily);

            _logger.LogInformation("Scheduled background job");
            return Ok();
        }
    }
}