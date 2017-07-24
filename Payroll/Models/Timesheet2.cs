using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Timesheet2
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string TsCode { get; set; }
        public decimal? TsDays { get; set; }
        public decimal? TsHrs { get; set; }
        public int? TsMins { get; set; }

        public virtual Timesheet2Code Timesheet2Code { get; set; }
    }
}
