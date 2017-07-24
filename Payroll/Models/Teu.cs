using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Teu
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool Active { get; set; }
    }
}
