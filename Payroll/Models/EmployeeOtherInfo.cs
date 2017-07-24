using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EmployeeOtherInfo
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string ExtraColumn1 { get; set; }
        public string ExtraColumn2 { get; set; }
        public string ExtraColumn3 { get; set; }
        public string ExtraColumn4 { get; set; }
        public string ExtraColumn5 { get; set; }
        public string ExtraColumn6 { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
