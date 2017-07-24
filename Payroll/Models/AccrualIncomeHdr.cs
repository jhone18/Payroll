using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class AccrualIncomeHdr
    {
        public AccrualIncomeHdr()
        {
            AccrualIncomeDtl = new HashSet<AccrualIncomeDtl>();
        }

        public Guid AccrualIncomeId { get; set; }
        public string CompanyId { get; set; }
        public int AppYear { get; set; }
        public int AppMonth { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<AccrualIncomeDtl> AccrualIncomeDtl { get; set; }
    }
}
