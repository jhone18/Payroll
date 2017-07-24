using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Ssstable
    {
        public int Id { get; set; }
        public int MonthlySalCredit { get; set; }
        public decimal LowerLimit { get; set; }
        public decimal UpperLimit { get; set; }
        public decimal EmployerSss { get; set; }
        public decimal EmployerEcc { get; set; }
        public decimal EmployeeSss { get; set; }
        public decimal? Total { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
