using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class RoleModule
    {
        public string Application { get; set; }
        public int RoleModId { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public bool HasCreate { get; set; }
        public bool HasUpdate { get; set; }
        public bool HasDelete { get; set; }
        public bool HasView { get; set; }
    }
}
