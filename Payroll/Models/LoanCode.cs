using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class LoanCode
    {
        public LoanCode()
        {
            Loan = new HashSet<Loan>();
        }

        public string CompanyId { get; set; }
        public string LoanCode1 { get; set; }
        public string LoanDescr { get; set; }
        public int? DedPriority { get; set; }
        public string LoanType { get; set; }
        public string AcctCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
        public string Currency { get; set; }

        public virtual ICollection<Loan> Loan { get; set; }
    }
}
