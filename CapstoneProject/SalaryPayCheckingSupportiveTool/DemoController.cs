using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaryPayCheckingSupportiveTool
{
  [Route("api/[controller]")]
  public class DemoController : Controller
  {
    public class Demo
    {
      public Demo(string test1, List<string> test3)
      {
        this.test1 = test1;
        this.test3 = test3;
      }

      public string test1 { get; set; }
      public List<string> test3 { get; set; }
    }
    // GET: api/<controller>
    [HttpGet]
    public IActionResult Get()
    {
      List<Demo> result2 = new List<Demo>();
      for (int i = 0; i < 5; i++)
      {
        string test1 = "Sinh vien " + i;
        List<string> test3 = new List<string>();
        test3.Add("Mã Môn " + ("x-" + i + "-y"));
        test3.Add("Mã Môn " + ("a-" + i + "-b"));
        test3.Add("Mã Môn " + ("i-" + i + "-j"));
        Demo result = new Demo(test1, test3);
        result2.Add(result);
      }
      return Ok(result2);
    }

    // GET api/<controller>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
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
