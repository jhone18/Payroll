using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Loan = new HashSet<Loan>();
        }

        public string CompanyId { get; set; }
        public string PayCode { get; set; }
        public string EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        public string PayrollType { get; set; }
        public bool? Confi { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Position { get; set; }
        public string CostCenter { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime DateEmployed { get; set; }
        public DateTime? DateRegularized { get; set; }
        public DateTime? DateTerminated { get; set; }
        public bool AllowedOt { get; set; }
        public string Teu { get; set; }
        public decimal? Salary { get; set; }
        public decimal? AdditionalHdmf { get; set; }
        public bool TwoPercentRate { get; set; }
        public string BankAcctNo { get; set; }
        public string BankCode { get; set; }
        public int? BranchId { get; set; }
        public string PagibigNumber { get; set; }
        public string Sssnumber { get; set; }
        public string Tin { get; set; }
        public string PhilhealthNumber { get; set; }
        public string PaymentType { get; set; }
        public decimal? TaxRate { get; set; }
        public string EmploymentType { get; set; }
        public string Rank { get; set; }
        public DateTime? PrevEmployerdate { get; set; }
        public string PrevEmployer { get; set; }
        public string PrevTin { get; set; }
        public string PrevEmployerAddr { get; set; }
        public decimal? GrossToPrevEmployer { get; set; }
        public decimal? WithheldToPrevEmployer { get; set; }
        public decimal? PrevSsshdmfph { get; set; }
        public decimal? PrevTaxed13thBonus { get; set; }
        public decimal? PrevNt13thBonus { get; set; }
        public decimal? PrevNtotherIncome { get; set; }
        public decimal? PrevTaxedOtherIncome { get; set; }
        public decimal? PrevBasicPay { get; set; }
        public decimal? PrevDeminimis { get; set; }
        public string EmployeeStatus { get; set; }
        public bool ZeroSss { get; set; }
        public bool ZeroPh { get; set; }
        public bool ZeroHdmf { get; set; }
        public bool ZeroTax { get; set; }
        public bool ComputeAsDaily { get; set; }
        public bool Modified { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? LastWorkDate { get; set; }

        public virtual EmployeeDepository EmployeeDepository { get; set; }
        public virtual EmployeeOtherInfo EmployeeOtherInfo { get; set; }
        public virtual ICollection<Loan> Loan { get; set; }
    }
}
