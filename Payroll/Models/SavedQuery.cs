using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class SavedQuery
    {
        public int Id { get; set; }
        public string CompanyId { get; set; }
        public string Title { get; set; }
        public string Sql { get; set; }
        public string Header { get; set; }
    }
}
