using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Earning
    {
        public long EarningId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string EarnCode { get; set; }
        public DateTime? TranDate { get; set; }
        public decimal Amount { get; set; }
        public DateTime? RecurStart { get; set; }
        public DateTime? RecurEnd { get; set; }
        public string Frequency { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }

        public virtual EarningCode EarningCode { get; set; }
    }
}
