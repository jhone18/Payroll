using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class PayMast
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public int PayrollNo { get; set; }
        public string Paycode { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public string CostCenter { get; set; }
        public string BankAcctNo { get; set; }
        public string BankCode { get; set; }
        public decimal? Salary { get; set; }
        public decimal DailyRate { get; set; }
        public decimal HourlyRate { get; set; }
        public string Teu { get; set; }
        public decimal BasicPay { get; set; }
        public decimal NetBasic { get; set; }
        public decimal NetBasic13thM { get; set; }
        public decimal TimesheetAmt { get; set; }
        public decimal Otamt { get; set; }
        public decimal TxEarning { get; set; }
        public decimal NtxEarning { get; set; }
        public decimal DedTaxAmt { get; set; }
        public decimal DeductionAmt { get; set; }
        public decimal GrossPay { get; set; }
        public decimal Wtax { get; set; }
        public decimal EmployeeSss { get; set; }
        public decimal EmployerSss { get; set; }
        public decimal EmployerEcc { get; set; }
        public decimal EmployeePh { get; set; }
        public decimal EmployerPh { get; set; }
        public decimal EmployeePagibig { get; set; }
        public decimal EmployerPagibig { get; set; }
        public decimal AdditionalHdmf { get; set; }
        public decimal LoanAmt { get; set; }
        public decimal NetPay { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
