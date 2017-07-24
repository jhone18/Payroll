using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class FieldAccess
    {
        public int Id { get; set; }
        public string Application { get; set; }
        public int RoleId { get; set; }
        public int FieldId { get; set; }
        public bool DenyView { get; set; }
        public bool DenyUpdate { get; set; }
    }
}
