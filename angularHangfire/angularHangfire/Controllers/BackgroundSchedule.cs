using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hangfire;
using Hangfire.Storage.Monitoring;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace angularHangfire.Controllers
{
    [Route("api/[controller]")]
    public class BackgroundSchedule : Controller
    {
        //long y = JobStorage.Current.GetMonitoringApi().ScheduledCount();


        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var JobList = JobStorage.Current.GetMonitoringApi();
            var scheduleJobs = JobList.ScheduledJobs(0, int.MaxValue);
            
            return Ok(scheduleJobs);
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            
            return "value";
        }
        [HttpGet("{jobID}/{jobCall}/{jobTime}")]
        public string Get(string jobID, string jobCall, int jobTime)
        {
            BackgroundJob.Delete(jobID);
            
            BackgroundJob.Schedule(() => Console.WriteLine(jobCall), TimeSpan.FromSeconds(jobTime));
            
            return "value";
        }


        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    }
}
