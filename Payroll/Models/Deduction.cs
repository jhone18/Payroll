using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Payroll.Models
{
    public partial class Deduction
    {
        public long DeductionId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? TranDate { get; set; }
        public string DedCode { get; set; }
        public decimal DedAmount { get; set; }
        public decimal? PsaDedAmount { get; set; }
        public string Frequency { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? RecurStart { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? RecurEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }

        public virtual DeductionCode DeductionCode { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
