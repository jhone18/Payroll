using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EmployeeFixedShare
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public decimal? EmployeeSss { get; set; }
        public decimal? EmployerSss { get; set; }
        public decimal? EmployerEcc { get; set; }
        public decimal? EmployeePh { get; set; }
        public decimal? EmployerPh { get; set; }
        public decimal? EmployeePagibig { get; set; }
        public decimal? EmployerPagibig { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
