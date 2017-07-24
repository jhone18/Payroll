using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class ProratedEarning
    {
        public string CompanyId { get; set; }
        public string EarnCode { get; set; }
        public string BaseTable { get; set; }
        public string BaseCode { get; set; }
        public string OutputTable { get; set; }
        public string OutputCode { get; set; }
        public int Id { get; set; }
        public bool ComputeMonthlyAsDaily { get; set; }
    }
}
