using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class CostCenter
    {
        public string CompanyId { get; set; }
        public string Cccode { get; set; }
        public string Ccdescr { get; set; }
    }
}
