using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class LoanStaging
    {
        public Guid SessionId { get; set; }
        public int RowId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LoanCode { get; set; }
        public decimal? Principal { get; set; }
        public decimal? WithInterest { get; set; }
        public decimal? TotalPayments { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Amortization { get; set; }
        public decimal? DeductAmount { get; set; }
        public string Frequency { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public string Remarks { get; set; }
        public bool Hold { get; set; }
    }
}
