using DataAccess;
using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CapstoneUI.Controllers
{
    [Route("api/payrollItem")]
    [ApiController]
    public class PayrollItemController : ControllerBase
    {
        private CapstoneContext _context;
        public PayrollItemController(CapstoneContext context)
        {
            _context = context;
        }
        [HttpPost("")]
        public IActionResult Create(PayrollItem pro)
        {
            try
            {
                pro = _context.PayrollItems.Add(pro).Entity;
                _context.SaveChanges();
                return Ok(new
                {
                    Id = pro.Id,
                    Message = "Ok"
                });
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
