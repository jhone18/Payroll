using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class PayCode
    {
        public string CompanyId { get; set; }
        public string PayCode1 { get; set; }
        public string Description { get; set; }
        public string PayrollFreq { get; set; }
        public string TaxTable { get; set; }
        public string TaxMethod { get; set; }
        public bool? CompXpayHoli { get; set; }
        public decimal WorkingDays { get; set; }
        public decimal HrsPerDay { get; set; }
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
        public bool? MonitorNetPay { get; set; }
        public int? NetPayLevel { get; set; }
        public string NetPayLevelBasis { get; set; }
        public decimal? Nd1rate { get; set; }
        public decimal? Nd2rate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
        public bool PagibigAmtSplit { get; set; }
        public bool ZeroTax { get; set; }
        public string Password { get; set; }
        public string ExportFolder { get; set; }
        public bool MinimumWager { get; set; }
        public bool SalaryRateHasAddOns { get; set; }
    }
}
