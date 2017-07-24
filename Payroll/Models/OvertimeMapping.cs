using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class OvertimeMapping
    {
        public string CompanyId { get; set; }
        public string TranId { get; set; }
        public string AcctCode { get; set; }
        public string Otcode { get; set; }
        public int Ottype { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }

        public virtual Otcode OtcodeNavigation { get; set; }
    }
}
