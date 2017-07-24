using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class ControlTotals
    {
        public int Id { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string FieldName { get; set; }
        public decimal? OldValue { get; set; }
        public decimal? NewValue { get; set; }
        public string Reason { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}
