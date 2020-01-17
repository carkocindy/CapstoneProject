using System;
using System.Collections.Generic;

namespace SalaryPayCheckingSupportiveTool.Models.DTOs
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public CompanyAccount CompanyAccount { get; set; }
    }
}
