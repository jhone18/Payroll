using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Loan
    {
        public long LoanId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LoanCode { get; set; }
        public decimal Principal { get; set; }
        public decimal WithInterest { get; set; }
        public decimal TotalPayments { get; set; }
        public decimal Balance { get; set; }
        public decimal Amortization { get; set; }
        public decimal DeductAmount { get; set; }
        public string Frequency { get; set; }
        public DateTime ApprovedDate { get; set; }
        public DateTime StartDate { get; set; }
        public string Remarks { get; set; }
        public bool Hold { get; set; }
        public bool Modified { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual LoanCode LoanCodeNavigation { get; set; }
    }
}
