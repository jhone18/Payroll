using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class CustomMethod
    {
        public string CompanyId { get; set; }
        public string MethodName { get; set; }
        public int ExecPriority { get; set; }
        public bool Enabled { get; set; }
    }
}
