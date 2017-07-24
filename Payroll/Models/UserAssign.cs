using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class UserAssign
    {
        public long UserAssId { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }
        public DateTime? DateAssigned { get; set; }
        public string PaycodeAccess { get; set; }
    }
}
