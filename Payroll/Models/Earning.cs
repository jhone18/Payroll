﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Payroll.Models
{
    public partial class Earning
    {
       
        public long EarningId { get; set; }
        public string CompanyId { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string EarnCode { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? TranDate { get; set; }
        public decimal Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? RecurStart { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? RecurEnd { get; set; }
        public string Frequency { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }

        public virtual EarningCode EarningCode { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
