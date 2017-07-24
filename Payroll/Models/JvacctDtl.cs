using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class JvacctDtl
    {
        public string CompanyId { get; set; }
        public string AcctCode { get; set; }
        public string SubAcctCode { get; set; }
        public string EmployeeDeptId { get; set; }
    }
}
