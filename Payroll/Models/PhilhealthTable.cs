using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class PhilhealthTable
    {
        public int Id { get; set; }
        public string Bracket { get; set; }
        public decimal LowerLimit { get; set; }
        public decimal UpperLimit { get; set; }
        public decimal EmployeePh { get; set; }
        public decimal EmployerPh { get; set; }
        public decimal? Total { get; set; }
        public decimal BaseSalary { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
