using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EmployeeDepository
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public int BankBranchId { get; set; }

        public virtual BankBranch BankBranch { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
