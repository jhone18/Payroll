using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Reports
    {
        public string ReportCode { get; set; }
        public string ReportName { get; set; }
        public string ReportType { get; set; }
        public bool Posted { get; set; }
        public string Crname { get; set; }
        public string Crname2 { get; set; }
        public string Crtitle { get; set; }
        public string MainSproc { get; set; }
        public string MainClass { get; set; }
        public string MainTableNames { get; set; }
        public string SubSproc { get; set; }
        public string SubClass { get; set; }
        public string SubTableNames { get; set; }
        public string DisketteForm { get; set; }
        public string DisketteFormType { get; set; }
        public string CreateDiskClass { get; set; }
        public bool WithSorting { get; set; }
        public bool WithGrouping { get; set; }
        public bool WithPaycodeFilter { get; set; }
        public bool WithDeptFilter { get; set; }
        public bool WithEmployeeFilter { get; set; }
        public bool WithLoanFilter { get; set; }
        public bool WithDeductionFilter { get; set; }
        public bool WithEarningFilter { get; set; }
        public bool Active { get; set; }
        public bool? CustomExport { get; set; }
        public string ExportFileName { get; set; }
        public int? PaperSize { get; set; }
        public int? PaperOrientation { get; set; }
        public int? LeftMargin { get; set; }
    }
}
