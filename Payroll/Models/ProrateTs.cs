using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class ProrateTs
    {
        public string CompanyId { get; set; }
        public string EarnCode { get; set; }
        public bool ProReg { get; set; }
        public bool ProAbs { get; set; }
        public bool ProTardy { get; set; }
        public bool ProUt { get; set; }
        public bool ProSl { get; set; }
        public bool ProVl { get; set; }
        public bool ProBackPayVl { get; set; }
        public bool ProBackPaySl { get; set; }
        public bool ProPaidHoli { get; set; }
    }
}
