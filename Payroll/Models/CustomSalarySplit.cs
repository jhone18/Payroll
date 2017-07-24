using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class CustomSalarySplit
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string SplitType { get; set; }
        public decimal FirstSplit { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
    }
}
