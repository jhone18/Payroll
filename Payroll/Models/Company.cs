using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    public partial class Company
    {
        public Company()
        {
            BankSignatory = new HashSet<BankSignatory>();
        }

        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPosition { get; set; }
        public string ApprovingOfficer { get; set; }
        public string OfficerPosition { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FaxNumber { get; set; }
        public string Tin { get; set; }
        public string Tinsignatory { get; set; }
        public string TinsignatoryPos { get; set; }
        public string Rdo { get; set; }
        public string W2signatory { get; set; }
        public string W2signatoryPos { get; set; }
        public string Sssnumber { get; set; }
        public string Ssssignatory { get; set; }
        public string SsssignatoryPos { get; set; }
        public string PhilhealthNumber { get; set; }
        public string PhilhealthSignatory { get; set; }
        public string PhilhealthSignatoryPos { get; set; }
        public string PagibigNumber { get; set; }
        public string PagibigSignatory { get; set; }
        public string PagibigSignatoryPos { get; set; }
        public bool Hierarchy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdBy { get; set; }
        public DateTime LastUpdDate { get; set; }
        public bool IncludeDeminimisInOt { get; set; }
        public string HoursInputFormat { get; set; }
        public string Zipcode { get; set; }
        public string Password { get; set; }
        public string ExportFolder { get; set; }
        public bool MultipleEmployeeBankAcct { get; set; }
        public bool EnableSalaryRateAddOns { get; set; }
        public bool EnableCustomSalarySplit { get; set; }
        public string CompCode { get; set; }
        public string PagibigBranchCode { get; set; }

        public virtual ICollection<BankSignatory> BankSignatory { get; set; }
    }
}
