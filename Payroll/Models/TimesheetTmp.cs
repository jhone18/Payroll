using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class TimesheetTmp
    {
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public int? PayrollNo { get; set; }
        public string CostCenter { get; set; }
        public decimal? RegDays { get; set; }
        public decimal? RegHours { get; set; }
        public decimal? Nd1regHours { get; set; }
        public decimal? Nd2regHours { get; set; }
        public decimal? Absences { get; set; }
        public decimal? TardyHours { get; set; }
        public decimal? Uthours { get; set; }
        public decimal? Sldays { get; set; }
        public decimal? Slhours { get; set; }
        public decimal? Vldays { get; set; }
        public decimal? Vlhours { get; set; }
        public decimal? BackPayVldays { get; set; }
        public decimal? BackPayVlhours { get; set; }
        public decimal? BackPaySldays { get; set; }
        public decimal? BackPaySlhours { get; set; }
        public decimal? PaidHolidays { get; set; }
        public decimal? PaidHoliHours { get; set; }
        public int? XxxpaidHolidays { get; set; }
        public decimal? RegAmt { get; set; }
        public decimal? Nd1regAmt { get; set; }
        public decimal? Nd2regAmt { get; set; }
        public decimal? AbsenceAmt { get; set; }
        public decimal? TardyAmt { get; set; }
        public decimal? Utamt { get; set; }
        public decimal? Slamt { get; set; }
        public decimal? Vlamt { get; set; }
        public decimal? BackPayVlamt { get; set; }
        public decimal? BackPaySlamt { get; set; }
        public decimal? PaidHoliAmt { get; set; }
        public decimal? AbsentHours { get; set; }
    }
}
