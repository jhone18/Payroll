using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Jvreport
    {
        public int RowId { get; set; }
        public string AcctCode { get; set; }
        public string AcctDescr { get; set; }
        public decimal? Dr { get; set; }
        public decimal? Cr { get; set; }
        public string Department { get; set; }
        public string EmpJvcode { get; set; }
    }
}
