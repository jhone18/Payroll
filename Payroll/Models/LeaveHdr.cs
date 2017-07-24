using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class LeaveHdr
    {
        public long LeaveHdrId { get; set; }
        public string CompanyId { get; set; }
        public int? PayrollNo { get; set; }
        public DateTime? TranDate { get; set; }
        public int AppYear { get; set; }
        public int? AppMonthFrom { get; set; }
        public int? AppMonthTo { get; set; }
        public string TranType { get; set; }
        public string Remarks { get; set; }
        public bool Modified { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
