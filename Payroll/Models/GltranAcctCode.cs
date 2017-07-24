using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class GltranAcctCode
    {
        public string CompanyId { get; set; }
        public string TranId { get; set; }
        public string AcctCode { get; set; }
        public string Drcr { get; set; }
    }
}
