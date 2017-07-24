using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class DeductionCode
    {
        public DeductionCode()
        {
            Deduction = new HashSet<Deduction>();
        }

        public string CompanyId { get; set; }
        public string DedCode { get; set; }
        public string DedDescr { get; set; }
        public bool DedTax { get; set; }
        public string DedTaxType { get; set; }
        public int? DedPriority { get; set; }
        public string AcctCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
        public string Currency { get; set; }

        public virtual ICollection<Deduction> Deduction { get; set; }
    }
}
