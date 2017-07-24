using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class LeaveType
    {
        public string CompanyId { get; set; }
        public decimal SlYearlyCredit { get; set; }
        public decimal VlYearlyCredit { get; set; }
        public string SlFreq { get; set; }
        public string VlFreq { get; set; }
        public decimal SlEarn { get; set; }
        public decimal VlEarn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
