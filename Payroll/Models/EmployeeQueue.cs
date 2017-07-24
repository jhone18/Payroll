using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class EmployeeQueue
    {
        public long Id { get; set; }
        public int JobType { get; set; }
        public int ReportType { get; set; }
        public string CompanyId { get; set; }
        public int RefNo { get; set; }
        public string EmployeeId { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public DateTime? StatusDate { get; set; }
        public Guid? ProcessId { get; set; }
    }
}
