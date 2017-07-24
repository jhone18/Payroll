using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class LoanTmp
    {
        public long LoanId { get; set; }
        public string CompanyId { get; set; }
        public int PayrollNo { get; set; }
        public string EmployeeId { get; set; }
        public string LoanCode { get; set; }
        public decimal Principal { get; set; }
        public decimal WithInterest { get; set; }
        public decimal TotalPayments { get; set; }
        public decimal Balance { get; set; }
        public decimal DeductAmount { get; set; }
        public string Remarks { get; set; }
        public decimal? PsaDeductAmount { get; set; }
    }
}
