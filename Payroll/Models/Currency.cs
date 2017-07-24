using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Currency
    {
        public Currency()
        {
            PayPeriod = new HashSet<PayPeriod>();
        }

        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PayPeriod> PayPeriod { get; set; }
    }
}
