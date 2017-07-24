using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class ClientCurrentTrans
    {
        public string CompanyId { get; set; }
        public Guid ClientPayrollTransId { get; set; }
        public DateTime? DateInitialized { get; set; }
        public string InitializedBy { get; set; }
    }
}
