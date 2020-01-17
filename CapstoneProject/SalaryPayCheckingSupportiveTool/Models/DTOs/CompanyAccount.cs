using System;
using System.Collections.Generic;

namespace SalaryPayCheckingSupportiveTool.Models.DTOs
{
    public partial class CompanyAccount
    {
        public CompanyAccount()
        {
            Formula = new HashSet<Formula>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Formula> Formula { get; set; }
    }
}
