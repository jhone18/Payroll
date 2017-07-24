using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Roles
    {
        public string Application { get; set; }
        public int RoleId { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
    }
}
