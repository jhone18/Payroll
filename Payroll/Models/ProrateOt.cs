using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class ProrateOt
    {
        public long ProrateId { get; set; }
        public string CompanyId { get; set; }
        public string EarnCode { get; set; }
        public string Otcode { get; set; }
    }
}
