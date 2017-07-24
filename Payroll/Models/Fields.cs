using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Fields
    {
        public int FieldId { get; set; }
        public string Application { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
    }
}
