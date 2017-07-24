using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class LeaveTran
    {
        public long Id { get; set; }
        public string CompanyId { get; set; }
        public long LeaveHdrId { get; set; }
        public int AppYear { get; set; }
        public int AppMonth { get; set; }
        public string EmployeeId { get; set; }
        public decimal? Sl { get; set; }
        public decimal? Vl { get; set; }
        public bool Modified { get; set; }
    }
}
