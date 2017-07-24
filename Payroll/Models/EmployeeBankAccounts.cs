using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EmployeeBankAccounts
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string BankAcctNumber { get; set; }
        public string CurrencyCode { get; set; }
        public int SalaryDistributionPriority { get; set; }
        public string SalaryDistributionType { get; set; }
        public decimal? SalaryDistributionFixAmt { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
