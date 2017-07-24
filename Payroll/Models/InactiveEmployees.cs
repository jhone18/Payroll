using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class InactiveEmployees
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public int PayrollNo { get; set; }
        public string EmployeeStatus { get; set; }
    }
}
