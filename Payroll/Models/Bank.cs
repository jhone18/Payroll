using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Bank
    {
        public Bank()
        {
            BankBranch = new HashSet<BankBranch>();
        }

        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }

        public virtual ICollection<BankBranch> BankBranch { get; set; }
    }
}
