using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Released
    {
        public int RowId { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string AppVersion { get; set; }
        public string DbVersion { get; set; }
        public string Remarks { get; set; }
        public string Script { get; set; }
    }
}
