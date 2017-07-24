using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class ProcessOptions
    {
        public string CompanyId { get; set; }
        public int PayrollNo { get; set; }
        public string TxEarncode { get; set; }
        public string NtxEarncode { get; set; }
        public string BonusBasis { get; set; }
        public string CurrBasicMethod { get; set; }
        public DateTime? PaymasFrom { get; set; }
        public DateTime? PaymasTo { get; set; }
        public DateTime? EarningFrom { get; set; }
        public DateTime? EarningTo { get; set; }
        public int? RemainingBonus { get; set; }
        public bool? AdjustPob { get; set; }
        public bool? ComputeBasic { get; set; }
        public bool? ComputeGovDed { get; set; }
        public bool? ComputeLoan { get; set; }
        public bool? ComputeRecDed { get; set; }
        public string TaxMethod { get; set; }
        public bool IsFinalTax { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
