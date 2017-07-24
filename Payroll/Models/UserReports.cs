using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class UserReports
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ReportCode { get; set; }
    }
}
