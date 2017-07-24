using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class ProcessException
    {
        public long Id { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
    }
}
