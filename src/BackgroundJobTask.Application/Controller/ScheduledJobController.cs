using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackgroundJobTask.BackgroundJob;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BackgroundJobTask.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduledJobController : ControllerBase
    {
        private readonly ILogger<ScheduledJobController> _logger;
        private readonly ScheduledJobWorker _scheduledJobWorker;

        public ScheduledJobController(ILogger<ScheduledJobController> logger, ScheduledJobWorker scheduledJobWorker)
        {
            _logger = logger;
            _scheduledJobWorker = scheduledJobWorker;
        }

        [HttpPost("scheduleJobs")]
        public IActionResult ScheduleJobs()
        {
            _scheduledJobWorker.ScheduleJobs();
            _logger.LogInformation("Job scheduled successfully!");
            return Ok("Job scheduled successfully!");
        }
    }
}
