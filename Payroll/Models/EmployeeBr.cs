using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EmployeeBr
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string Otcode { get; set; }
        public decimal Otrate { get; set; }
        public decimal Ot8rate { get; set; }
        public decimal OtrateNd1 { get; set; }
    }
}
