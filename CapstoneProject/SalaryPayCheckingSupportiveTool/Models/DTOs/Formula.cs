using System;
using System.Collections.Generic;

namespace SalaryPayCheckingSupportiveTool.Models.DTOs
{
    public partial class Formula
    {
        public int Id { get; set; }
        public string FormulaName { get; set; }
        public string FormulaString { get; set; }
        public int CompanyAccountId { get; set; }
        public bool IsSalaryFormula { get; set; }

        public CompanyAccount CompanyAccount { get; set; }
    }
}
