using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class TimesheetMapping
    {
        public string CompanyId { get; set; }
        public string TranId { get; set; }
        public string TsColumn { get; set; }
        public string AcctCode { get; set; }
        public string Description { get; set; }
    }
}
