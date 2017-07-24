using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Otcode
    {
        public Otcode()
        {
            Otsheet = new HashSet<Otsheet>();
            OvertimeMapping = new HashSet<OvertimeMapping>();
        }

        public string CompanyId { get; set; }
        public string Otcode1 { get; set; }
        public string Otdescription { get; set; }
        public decimal Otrate { get; set; }
        public decimal? Ot8rate { get; set; }
        public decimal OtrateNd1 { get; set; }
        public decimal OtrateNd2 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
        public decimal? Otbrate { get; set; }
        public decimal? Ot8brate { get; set; }
        public decimal? OtbrateNd1 { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<Otsheet> Otsheet { get; set; }
        public virtual ICollection<OvertimeMapping> OvertimeMapping { get; set; }
    }
}
