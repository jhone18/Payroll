using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class MailQueue2
    {
        public string CompanyId { get; set; }
        public int Year { get; set; }
        public string EmployeeId { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public DateTime? StatusDate { get; set; }
        public Guid? ProcessId { get; set; }
    }
}
