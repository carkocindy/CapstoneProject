using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SalaryPayCheckingSupportiveTool.Models.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaryPayCheckingSupportiveTool
{
  [Route("api/[controller]")]
  public class DemoController : Controller
  {
    private DemoFormulaContext db = new DemoFormulaContext();
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
      return Ok(db.Formula.ToList());
    }

    // GET api/<controller>/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
      List<Formula> result = new List<Formula>();
      CompanyAccount companyAccount = db.CompanyAccount.Find(id);
      if (companyAccount != null)
      {
        List<Formula> temp = db.Formula.Where(f => f.CompanyAccountId == companyAccount.Id).ToList();
        foreach (var item in temp)
        {
          //item.CompanyAccount = null;
          result.Add(item);
        }
      }
      return Ok(result);
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
