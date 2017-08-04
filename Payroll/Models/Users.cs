using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Payroll.Models
{
    public partial class Users
    {
        public string Application { get; set; }
        [Required]
        public string UserId { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string Password { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? Activated { get; set; }
        public string Status { get; set; }
    }
}
