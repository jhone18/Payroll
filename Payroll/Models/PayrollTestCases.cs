using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class PayrollTestCases
    {
        public int TestNo { get; set; }
        public string ProcessType { get; set; }
        public int? PayrollNo { get; set; }
        public string CompanyId { get; set; }
        public string PayCode { get; set; }
        public string PayrollFreq { get; set; }
        public string TaxTable { get; set; }
        public string TaxMethod { get; set; }
        public decimal WorkingDays { get; set; }
        public int HrsPerDay { get; set; }
        public string Sssbasis { get; set; }
        public string Sssfrequency { get; set; }
        public int? SssbasisDays { get; set; }
        public string PhilhealthBasis { get; set; }
        public string PhilhealthFreq { get; set; }
        public int? PhilhealthBasisDays { get; set; }
        public string PagibigBasis { get; set; }
        public string PagibigFreq { get; set; }
        public int? PagibigBasisDays { get; set; }
        public int PayPeriodPerYear { get; set; }
        public int BonusPerYear { get; set; }
        public int? DaysPerWeek { get; set; }
        public bool RequireTimesheet { get; set; }
        public bool IncBonTaxDiv { get; set; }
        public bool BpLessAbs { get; set; }
        public bool BpLessTardy { get; set; }
        public bool BpLessUt { get; set; }
        public bool BpLessVl { get; set; }
        public bool BpLessSl { get; set; }
        public bool BpLessAbs2 { get; set; }
        public bool BpLessTardy2 { get; set; }
        public bool BpLessUt2 { get; set; }
        public bool BpLessVl2 { get; set; }
        public bool BpLessSl2 { get; set; }
        public bool TaxableOt { get; set; }
        public string TsTimeFormat { get; set; }
        public string OtTimeFormat { get; set; }
        public string BonusBasis { get; set; }
        public string BonusBasisCb { get; set; }
    }
}
