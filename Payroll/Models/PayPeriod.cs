using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class PayPeriod
    {
        public string CompanyId { get; set; }
        public int PayrollNo { get; set; }
        public string PayrollFreq { get; set; }
        public string ProcessType { get; set; }
        public bool Compute13thM { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public DateTime PayDate { get; set; }
        public int ApplicableMonth { get; set; }
        public int ApplicableYear { get; set; }
        public int? ManDays { get; set; }
        public DateTime CutOffFrom { get; set; }
        public DateTime CutOffTo { get; set; }
        public decimal? ExchangeRate { get; set; }
        public int FiscalYear { get; set; }
        public int? PayrollWeekNo { get; set; }
        public string WeekNo { get; set; }
        public string PayrollStatus { get; set; }
        public bool ExportedByProvider { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
        public string Currency { get; set; }
        public string Remarks { get; set; }

        public virtual Currency CurrencyNavigation { get; set; }
    }
}
