using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Section
    {
        public string CompanyId { get; set; }
        public string SectCode { get; set; }
        public string SectDescr { get; set; }
        public string DeptCode { get; set; }
    }
}
