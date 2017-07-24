using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class LeaveBalance
    {
        public string CompanyId { get; set; }
        public int PayrollNo { get; set; }
        public string EmployeeId { get; set; }
        public string LeaveCode { get; set; }
        public decimal Balance { get; set; }
    }
}
