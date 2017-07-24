using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EarningStaging
    {
        public Guid SessionId { get; set; }
        public int Id { get; set; }
        public int RowId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string EarnCode { get; set; }
        public DateTime? TranDate { get; set; }
        public decimal Amount { get; set; }
    }
}
