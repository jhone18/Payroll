using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EmployeeYearEnd
    {
        public string CompanyId { get; set; }
        public int Year { get; set; }
        public string EmployeeId { get; set; }
        public string Paycode { get; set; }
        public string Teu { get; set; }
        public string Department { get; set; }
        public DateTime DateRefreshed { get; set; }
    }
}
