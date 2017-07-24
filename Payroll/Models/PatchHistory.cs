using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class PatchHistory
    {
        public Guid PatchId { get; set; }
        public DateTime PatchDate { get; set; }
        public string AppVersion { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
