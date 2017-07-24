using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Users
    {
        public string Application { get; set; }
        public string UserId { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string Password { get; set; }
        public DateTime? Activated { get; set; }
        public string Status { get; set; }
    }
}
