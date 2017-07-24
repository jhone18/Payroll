using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Otsheet
    {
        public long OtsheetId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string Otcode { get; set; }
        public string CostCenter { get; set; }
        public decimal? Othours { get; set; }
        public decimal? Ot8hours { get; set; }
        public decimal? Otndhours { get; set; }
        public decimal? Otnd2hours { get; set; }
        public string Frequency { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }

        public virtual Otcode OtcodeNavigation { get; set; }
    }
}
