using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class LeaveTypes
    {
        public string CompanyId { get; set; }
        public string LeaveCode { get; set; }
        public string Descr { get; set; }
        public string Frequency { get; set; }
        public decimal Earning { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
