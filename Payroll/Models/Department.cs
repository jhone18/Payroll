using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Department
    {
        public string CompanyId { get; set; }
        public string DeptCode { get; set; }
        public string DeptDescr { get; set; }
        public string DivCode { get; set; }
    }
}
