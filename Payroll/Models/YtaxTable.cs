using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class YtaxTable
    {
        public int Id { get; set; }
        public decimal Llimit { get; set; }
        public decimal Ulimit { get; set; }
        public decimal Fa { get; set; }
        public decimal Pct { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
