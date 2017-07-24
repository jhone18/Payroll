using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class DeductionStaging
    {
        public Guid SessionId { get; set; }
        public int Id { get; set; }
        public int RowId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? TranDate { get; set; }
        public string DedCode { get; set; }
        public decimal DedAmount { get; set; }
    }
}
