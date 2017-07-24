using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class AppChangedLog
    {
        public string Version { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Changes { get; set; }
    }
}
