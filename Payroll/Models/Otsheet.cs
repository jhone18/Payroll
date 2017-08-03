using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll.Models
{
    public partial class Otsheet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OtsheetId { get; set; }
        [Key]
        public string CompanyId { get; set; }
        [Key]
        public string EmployeeId { get; set; }
        [Key]
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
