using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class OtsheetStaging
    {
        public Guid SessionId { get; set; }
        public int Id { get; set; }
        public int RowId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string Otcode { get; set; }
        public decimal? Othours { get; set; }
        public decimal? Ot8hours { get; set; }
        public decimal? Otndhours { get; set; }
        public decimal? Otnd2hours { get; set; }
    }
}
