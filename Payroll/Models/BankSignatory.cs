using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class BankSignatory
    {
        public string CompanyId { get; set; }
        public int BankSignatoryId { get; set; }
        public string BankSignatory1 { get; set; }
        public string BankSignatoryPos { get; set; }
        public int? DisplayOrder { get; set; }
        public string Type { get; set; }

        public virtual Company Company { get; set; }
    }
}
