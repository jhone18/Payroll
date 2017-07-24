using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class GovPayment
    {
        public string CompanyId { get; set; }
        public int ApplicableYear { get; set; }
        public int ApplicableMonth { get; set; }
        public string SssOrNo { get; set; }
        public DateTime? SssOrDate { get; set; }
        public decimal? SssOrAmount { get; set; }
        public string PhOrNo { get; set; }
        public DateTime? PhOrDate { get; set; }
        public decimal? PhOrAmount { get; set; }
        public string PagOrNo { get; set; }
        public DateTime? PagOrDate { get; set; }
        public decimal? PagOrAmount { get; set; }
    }
}
