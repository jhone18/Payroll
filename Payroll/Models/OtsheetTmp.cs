using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class OtsheetTmp
    {
        public long OtsheetId { get; set; }
        public string CompanyId { get; set; }
        public int PayrollNo { get; set; }
        public string EmployeeId { get; set; }
        public string Otcode { get; set; }
        public string CostCenter { get; set; }
        public decimal? Othours { get; set; }
        public decimal? Ot8hours { get; set; }
        public decimal? Otndhours { get; set; }
        public decimal? Otnd2hours { get; set; }
        public string Frequency { get; set; }
        public decimal? Otamt { get; set; }
        public decimal? Ot8amt { get; set; }
        public decimal? Nd1amt { get; set; }
        public decimal? Nd2amt { get; set; }
    }
}
