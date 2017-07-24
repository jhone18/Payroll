using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class DeductionFromTs
    {
        public string CompanyId { get; set; }
        public string Tscode { get; set; }
        public string EarnCode { get; set; }
        public string DedCodeTarget { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
