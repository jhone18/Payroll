using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class CompanySettings
    {
        public string CompanyId { get; set; }
        public bool HidePayslipLoanBalance { get; set; }
    }
}
