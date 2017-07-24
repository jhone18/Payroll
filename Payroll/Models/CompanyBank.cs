using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class CompanyBank
    {
        public string CompanyId { get; set; }
        public int BankBranchId { get; set; }
        public string BankAcctNumber { get; set; }
        public string BankAcctType { get; set; }
        public string BranchNumber { get; set; }
        public string BankDiskType { get; set; }
        public string CorporateId { get; set; }

        public virtual BankBranch BankBranch { get; set; }
    }
}
