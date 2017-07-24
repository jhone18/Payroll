using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Signatories
    {
        public string CompanyId { get; set; }
        public string SignatoryType { get; set; }
        public string SignatoryName { get; set; }
        public string Position { get; set; }
        public string SignatoryHeader { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsApprover { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
    }
}
