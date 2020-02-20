using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hangfire;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace angularHangfire.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        string textJob;
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
           
            //var processingJobs = JobStorage.Current.GetMonitoringApi().ScheduledJobs(0, 2000);
            return Ok();
        }

        // GET api/<controller>/5
        [HttpGet("{id}/{jobID}")]
        public IActionResult Get(int id, string jobID)
        {
            textJob = id + " second has passed!";
            //BackgroundJob.Schedule(() => Console.WriteLine(textJob), TimeSpan.FromSeconds(id));
            //var x = JobStorage.Current.GetMonitoringApi().ScheduledJobs(0,2000);
            //Max for second in recurring is 60
            RecurringJob.AddOrUpdate(jobID, () => removeRecurring(DateTime.Now,jobID),"*/" + id + " * * * * *");
            return Ok();
        }
        public void removeRecurring(DateTime xx, string jobID)
        {
            Console.WriteLine(xx);
            RecurringJob.RemoveIfExists(jobID);
        }

        [HttpGet("{day}/{month}/{hour}/{minute}/{second}/{jobID}")]
        public string Get(int day, int month, int hour, int minute, int second, string jobID)
        {
            RecurringJob.AddOrUpdate(jobID, () => removeRecurring(DateTime.Now,jobID),
                "*/" + second + " " + minute + " " + hour + " " + day + " " + month + " *", TimeZoneInfo.Local);
            return "value";
        }
        public void consoleLine(DateTime consoleXX)
        {
            Console.WriteLine(consoleXX);
        }

        [HttpGet("{day}/{month}/{jobID}")]
        public string Get(int day, int month, string jobID)
        {
            RecurringJob.AddOrUpdate(jobID,() => Console.WriteLine(DateTime.Now),
                "* * " + day + " " + month + " *", TimeZoneInfo.Local);
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
        public void Delete(string id)
        {
            //BackgroundJob.Delete(id);
            RecurringJob.RemoveIfExists(id);
        }


    }
}
