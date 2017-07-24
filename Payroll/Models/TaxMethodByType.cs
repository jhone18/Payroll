using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class TaxMethodByType
    {
        public string CompanyId { get; set; }
        public string ProcessType { get; set; }
        public string PayCode { get; set; }
        public string TaxMethod { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
