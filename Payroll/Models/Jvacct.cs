using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Jvacct
    {
        public string CompanyId { get; set; }
        public string AcctCode { get; set; }
        public string AcctDescr { get; set; }
        public string Drcr { get; set; }
        public string Presentation { get; set; }
        public string Formula { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
        public string AcctCode2 { get; set; }
    }
}
