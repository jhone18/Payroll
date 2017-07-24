using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EmployeeStaging
    {
        public Guid SessionId { get; set; }
        public long Id { get; set; }
        public int RowId { get; set; }
        public string PayCode { get; set; }
        public string EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PayrollType { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Position { get; set; }
        public string CostCenter { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }
        public string DeptDescr { get; set; }
        public string Section { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DateEmployed { get; set; }
        public DateTime? DateRegularized { get; set; }
        public DateTime? DateTerminated { get; set; }
        public bool? AllowedOt { get; set; }
        public string Teu { get; set; }
        public decimal? Salary { get; set; }
        public decimal? AdditionalHdmf { get; set; }
        public bool? TwoPercentRate { get; set; }
        public string BankAcctNo { get; set; }
        public string BankCode { get; set; }
        public string BranchId { get; set; }
        public string PagibigNumber { get; set; }
        public string Sssnumber { get; set; }
        public string Tin { get; set; }
        public string PhilhealthNumber { get; set; }
        public string PaymentType { get; set; }
        public decimal? TaxRate { get; set; }
        public string EmploymentType { get; set; }
        public string Rank { get; set; }
        public string EmployeeStatus { get; set; }
        public bool? ZeroSss { get; set; }
        public bool? ZeroPh { get; set; }
        public bool? ZeroHdmf { get; set; }
        public bool? ZeroTax { get; set; }
        public bool? ComputeAsDaily { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastWorkDate { get; set; }
        public string ExtraColumn1 { get; set; }
        public string ExtraColumn2 { get; set; }
        public string ExtraColumn3 { get; set; }
        public string ExtraColumn4 { get; set; }
        public string ExtraColumn5 { get; set; }
        public string ExtraColumn6 { get; set; }
    }
}
