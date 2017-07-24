using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class ExcelError
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int? RowNum { get; set; }
        public int? Severity { get; set; }
    }
}
