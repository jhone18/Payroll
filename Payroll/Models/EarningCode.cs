using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EarningCode
    {
        public EarningCode()
        {
            Earning = new HashSet<Earning>();
        }

        public string CompanyId { get; set; }
        public string EarnCode { get; set; }
        public string EarnDescr { get; set; }
        public bool Taxable { get; set; }
        public bool IncludeSss { get; set; }
        public bool IncludePagibig { get; set; }
        public bool IncludePhilhealth { get; set; }
        public bool IncludeInAlpha { get; set; }
        public bool IncludeInBonus { get; set; }
        public bool PartOfBonus { get; set; }
        public bool? Prorate { get; set; }
        public string AcctCode { get; set; }
        public bool Bir2316 { get; set; }
        public string Birtype { get; set; }
        public bool Deminimis { get; set; }
        public bool SalaryRateAddOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
        public string Currency { get; set; }
        public bool UseAddOnRateOt { get; set; }

        public virtual ICollection<Earning> Earning { get; set; }
    }
}
