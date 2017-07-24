using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class GlAccount
    {
        public string CompanyId { get; set; }
        public string AcctCode { get; set; }
        public string AcctDescr { get; set; }
        public string Drcr { get; set; }
    }
}
