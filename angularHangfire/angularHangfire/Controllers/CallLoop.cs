using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace angularHangfire.Controllers
{
    [Route("api/[controller]")]
    public class CallLoop : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            RecurringJob.RemoveIfExists("reCurLoop");
            return new string[] { "value1", "value2" };
        }


        // GET api/<controller>/5
        [HttpGet("{id}/{jobID}")]
        public string Get(int id, string jobID)
        {
            RecurringJob.AddOrUpdate(jobID, () => Console.WriteLine(id + " second has passed for Loop!"), "*/" + id + " * * * * *");
            return "value";
        }

        [HttpGet("{day}/{month}/{hour}/{minute}/{second}/{jobID}")]
        public string Get(int day, int month, int hour, int minute, int second, string jobID)
        {
            RecurringJob.AddOrUpdate(jobID, () => removeRecurring(jobID),
                "*/" + second + " " + minute + " " + hour + " " + day + " " + month + " *", TimeZoneInfo.Local);
            return "value";
        }
        public void removeRecurring(string jobId)
        {
            Console.WriteLine(DateTime.Now);
            RecurringJob.RemoveIfExists(jobId);
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
            RecurringJob.RemoveIfExists(id);
        }
    }
}
