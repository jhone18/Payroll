using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class LeaveTranTmp
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public int PayrollNo { get; set; }
        public DateTime PayDate { get; set; }
        public decimal? Sl { get; set; }
        public decimal? Vl { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
