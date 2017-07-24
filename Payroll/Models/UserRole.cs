using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class UserRole
    {
        public string Application { get; set; }
        public int UserRoleId { get; set; }
        public string UserId { get; set; }
        public int RoleId { get; set; }
    }
}
