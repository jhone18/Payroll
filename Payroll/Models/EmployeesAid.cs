using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EmployeesAid
    {
        public Guid SessionId { get; set; }
        public string EmployeeId { get; set; }
    }
}
