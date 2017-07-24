using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Modules
    {
        public string Application { get; set; }
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string Description { get; set; }
        public string Hierarchy { get; set; }
        public string Url { get; set; }
        public string ModuleCode { get; set; }
        public bool ShowMenu { get; set; }
    }
}
