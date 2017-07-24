using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class TimesheetTmp2
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string TsCode { get; set; }
        public int PayrollNo { get; set; }
        public decimal? TsDays { get; set; }
        public decimal? TsHrs { get; set; }
        public decimal TsAmt { get; set; }
        public int? TsMins { get; set; }
    }
}
