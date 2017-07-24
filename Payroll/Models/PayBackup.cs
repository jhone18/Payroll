using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class PayBackup
    {
        public string CompanyId { get; set; }
        public int PayrollNo { get; set; }
        public string BackupFileName { get; set; }
        public DateTime BackupDate { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
    }
}
