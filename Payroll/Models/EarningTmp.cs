using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EarningTmp
    {
        public long Id { get; set; }
        public long EarningId { get; set; }
        public string CompanyId { get; set; }
        public int? PayrollNo { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? Trandate { get; set; }
        public string EarnCode { get; set; }
        public decimal Amount { get; set; }
    }
}
