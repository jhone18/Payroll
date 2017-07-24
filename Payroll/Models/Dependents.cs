using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Dependents
    {
        public int RowId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string DependentName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
