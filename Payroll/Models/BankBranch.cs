using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class BankBranch
    {
        public BankBranch()
        {
            CompanyBank = new HashSet<CompanyBank>();
            EmployeeDepository = new HashSet<EmployeeDepository>();
        }

        public int BankBranchId { get; set; }
        public string BankCode { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPosition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }

        public virtual ICollection<CompanyBank> CompanyBank { get; set; }
        public virtual ICollection<EmployeeDepository> EmployeeDepository { get; set; }
        public virtual Bank BankCodeNavigation { get; set; }
    }
}
