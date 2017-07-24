using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class DivisionSalary
    {
        public Guid Id { get; set; }
        public string CompanyId { get; set; }
        public string DivCode { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateChanged { get; set; }
        public string ChangedBy { get; set; }
        public string Remarks { get; set; }
    }
}
