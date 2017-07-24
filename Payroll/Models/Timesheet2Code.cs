using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Timesheet2Code
    {
        public Timesheet2Code()
        {
            Timesheet2 = new HashSet<Timesheet2>();
        }

        public string CompanyId { get; set; }
        public string TsCode { get; set; }
        public string TsName { get; set; }
        public string TsDescr { get; set; }
        public int DisplayOrder { get; set; }
        public int Multiplier { get; set; }
        public bool Taxable { get; set; }
        public string AcctCode { get; set; }
        public bool Active { get; set; }
        public bool HasDayInput { get; set; }
        public string TsType { get; set; }

        public virtual ICollection<Timesheet2> Timesheet2 { get; set; }
    }
}
