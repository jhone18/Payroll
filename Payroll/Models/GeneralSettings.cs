using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class GeneralSettings
    {
        public string CompanyId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
    }
}
