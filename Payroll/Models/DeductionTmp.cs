using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class DeductionTmp
    {
        public long Id { get; set; }
        public long DeductionId { get; set; }
        public string CompanyId { get; set; }
        public int? PayrollNo { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? Trandate { get; set; }
        public string DedCode { get; set; }
        public decimal DedAmount { get; set; }
        public decimal? PsaDedAmount { get; set; }
    }
}
