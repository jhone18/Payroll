using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class AccrualIncomeDtl
    {
        public int Uid { get; set; }
        public Guid AccrualIncomeId { get; set; }
        public string EmployeeId { get; set; }
        public string Earncode { get; set; }
        public decimal Hrs { get; set; }
        public decimal Amount { get; set; }
        public decimal Salary { get; set; }

        public virtual AccrualIncomeHdr AccrualIncome { get; set; }
    }
}
