
using JobExplorer.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobExplorer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobExplorerController : ControllerBase
    {
        private readonly JobExplorerService _jobService;

        public JobExplorerController(JobExplorerService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<IActionResult> GetJobs()
        {
            var jobs = await _jobService.GetJobsAsync();
            return Ok(jobs);
        }
    }
    
}
