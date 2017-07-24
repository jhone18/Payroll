using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class TimesheetStaging
    {
        public Guid SessionId { get; set; }
        public int RowId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
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
        public int Id { get; set; }
        public decimal? AbsentHours { get; set; }
    }
}
