using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
   public class PayrollItem : _BaseEntity
    {
        public string Name { get; set; }
        public bool IsPositive { get; set; }
        public string Type { get; set; }
    }
}
