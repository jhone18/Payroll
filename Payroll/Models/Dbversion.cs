using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Dbversion
    {
        public string Version { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
    }
}
