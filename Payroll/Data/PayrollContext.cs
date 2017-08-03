using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Payroll.Models;

namespace Payroll.Data
{
    public partial class PayrollContext : DbContext
    {
        public virtual DbSet<AccrualIncomeDtl> AccrualIncomeDtl { get; set; }
        public virtual DbSet<AccrualIncomeHdr> AccrualIncomeHdr { get; set; }
        public virtual DbSet<AppChangedLog> AppChangedLog { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankBranch> BankBranch { get; set; }
        public virtual DbSet<BankSignatory> BankSignatory { get; set; }
        public virtual DbSet<ClientCurrentTrans> ClientCurrentTrans { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyBank> CompanyBank { get; set; }
        public virtual DbSet<CompanySettings> CompanySettings { get; set; }
        public virtual DbSet<ControlTotals> ControlTotals { get; set; }
        public virtual DbSet<CostCenter> CostCenter { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CustomMethod> CustomMethod { get; set; }
        public virtual DbSet<CustomSalarySplit> CustomSalarySplit { get; set; }
        public virtual DbSet<Dbversion> Dbversion { get; set; }
        public virtual DbSet<Deduction> Deduction { get; set; }
        public virtual DbSet<DeductionCode> DeductionCode { get; set; }
        public virtual DbSet<DeductionFromTs> DeductionFromTs { get; set; }
        public virtual DbSet<DeductionMapping> DeductionMapping { get; set; }
        public virtual DbSet<DeductionStaging> DeductionStaging { get; set; }
        public virtual DbSet<DeductionTmp> DeductionTmp { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Dependents> Dependents { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<DivisionSalary> DivisionSalary { get; set; }
        public virtual DbSet<Earning> Earning { get; set; }
        public virtual DbSet<EarningCode> EarningCode { get; set; }
        public virtual DbSet<EarningMapping> EarningMapping { get; set; }
        public virtual DbSet<EarningStaging> EarningStaging { get; set; }
        public virtual DbSet<EarningTmp> EarningTmp { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeBankAccounts> EmployeeBankAccounts { get; set; }
        public virtual DbSet<EmployeeBr> EmployeeBr { get; set; }
        public virtual DbSet<EmployeeDepository> EmployeeDepository { get; set; }
        public virtual DbSet<EmployeeFixedShare> EmployeeFixedShare { get; set; }
        public virtual DbSet<EmployeeJvcode> EmployeeJvcode { get; set; }
        public virtual DbSet<EmployeeOtherInfo> EmployeeOtherInfo { get; set; }
        public virtual DbSet<EmployeeQueue> EmployeeQueue { get; set; }
        public virtual DbSet<EmployeeStaging> EmployeeStaging { get; set; }
        public virtual DbSet<EmployeeStatus> EmployeeStatus { get; set; }
        public virtual DbSet<EmployeeYearEnd> EmployeeYearEnd { get; set; }
        public virtual DbSet<EmployeesAid> EmployeesAid { get; set; }
        public virtual DbSet<EmploymentType> EmploymentType { get; set; }
        public virtual DbSet<ExcelError> ExcelError { get; set; }
        public virtual DbSet<GeneralSettings> GeneralSettings { get; set; }
        public virtual DbSet<GlAccount> GlAccount { get; set; }
        public virtual DbSet<GltranAcctCode> GltranAcctCode { get; set; }
        public virtual DbSet<GovBasis> GovBasis { get; set; }
        public virtual DbSet<GovPayment> GovPayment { get; set; }
        public virtual DbSet<InactiveEmployees> InactiveEmployees { get; set; }
        public virtual DbSet<IncomeFromOt> IncomeFromOt { get; set; }
        public virtual DbSet<Jvacct> Jvacct { get; set; }
        public virtual DbSet<JvacctDtl> JvacctDtl { get; set; }
        public virtual DbSet<Jvreport> Jvreport { get; set; }
        public virtual DbSet<LeaveBalance> LeaveBalance { get; set; }
        public virtual DbSet<LeaveHdr> LeaveHdr { get; set; }
        public virtual DbSet<LeaveTran> LeaveTran { get; set; }
        public virtual DbSet<LeaveTranTmp> LeaveTranTmp { get; set; }
        public virtual DbSet<LeaveType> LeaveType { get; set; }
        public virtual DbSet<LeaveTypes> LeaveTypes { get; set; }
        public virtual DbSet<Loan> Loan { get; set; }
        public virtual DbSet<LoanCode> LoanCode { get; set; }
        public virtual DbSet<LoanStaging> LoanStaging { get; set; }
        public virtual DbSet<LoanSumm> LoanSumm { get; set; }
        public virtual DbSet<LoanTmp> LoanTmp { get; set; }
        public virtual DbSet<MailQueue> MailQueue { get; set; }
        public virtual DbSet<MailQueue2> MailQueue2 { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<MtaxTable> MtaxTable { get; set; }
        public virtual DbSet<Otcode> Otcode { get; set; }
        public virtual DbSet<Otsheet> Otsheet { get; set; }
        public virtual DbSet<OtsheetStaging> OtsheetStaging { get; set; }
        public virtual DbSet<OtsheetTmp> OtsheetTmp { get; set; }
        public virtual DbSet<OvertimeMapping> OvertimeMapping { get; set; }
        public virtual DbSet<PatchHistory> PatchHistory { get; set; }
        public virtual DbSet<PayBackup> PayBackup { get; set; }
        public virtual DbSet<PayCode> PayCode { get; set; }
        public virtual DbSet<PayMast> PayMast { get; set; }
        public virtual DbSet<PayPeriod> PayPeriod { get; set; }
        public virtual DbSet<PayPeriodStaging> PayPeriodStaging { get; set; }
        public virtual DbSet<PayrollFreq> PayrollFreq { get; set; }
        public virtual DbSet<PayrollTestCases> PayrollTestCases { get; set; }
        public virtual DbSet<PayrollTestResults> PayrollTestResults { get; set; }
        public virtual DbSet<PayrollType> PayrollType { get; set; }
        public virtual DbSet<PhilhealthTable> PhilhealthTable { get; set; }
        public virtual DbSet<Pivot> Pivot { get; set; }
        public virtual DbSet<ProcessException> ProcessException { get; set; }
        public virtual DbSet<ProcessOptions> ProcessOptions { get; set; }
        public virtual DbSet<ProrateOt> ProrateOt { get; set; }
        public virtual DbSet<ProrateTs> ProrateTs { get; set; }
        public virtual DbSet<ProratedEarning> ProratedEarning { get; set; }
        public virtual DbSet<Rank> Rank { get; set; }
        public virtual DbSet<Reason> Reason { get; set; }
        public virtual DbSet<Released> Released { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<SavedQuery> SavedQuery { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Signatories> Signatories { get; set; }
        public virtual DbSet<Ssstable> Ssstable { get; set; }
        public virtual DbSet<StaxTable> StaxTable { get; set; }
        public virtual DbSet<TaxMethodByType> TaxMethodByType { get; set; }
        public virtual DbSet<Teu> Teu { get; set; }
        public virtual DbSet<Timesheet> Timesheet { get; set; }
        public virtual DbSet<Timesheet2> Timesheet2 { get; set; }
        public virtual DbSet<Timesheet2Code> Timesheet2Code { get; set; }
        public virtual DbSet<Timesheet2Staging> Timesheet2Staging { get; set; }
        public virtual DbSet<TimesheetMapping> TimesheetMapping { get; set; }
        public virtual DbSet<TimesheetStaging> TimesheetStaging { get; set; }
        public virtual DbSet<TimesheetTmp> TimesheetTmp { get; set; }
        public virtual DbSet<TimesheetTmp2> TimesheetTmp2 { get; set; }
        public virtual DbSet<UserAssDtl> UserAssDtl { get; set; }
        public virtual DbSet<UserAssign> UserAssign { get; set; }
        public virtual DbSet<UserReports> UserReports { get; set; }
        public virtual DbSet<WtaxTable> WtaxTable { get; set; }
        public virtual DbSet<YtaxTable> YtaxTable { get; set; }

        // Unable to generate entity type for table 'dbo.RptParameters'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProratedIncome'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PrintedPayslipList'. Please see the warning messages.

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-JUSM0M5\SQLEXPRESS;Database=Payroll_DEV2;Trusted_Connection=True;");
        //}
        public PayrollContext(DbContextOptions<PayrollContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccrualIncomeDtl>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK_AccrualIncomeDtl");

                entity.HasIndex(e => e.AccrualIncomeId)
                    .HasName("IX_AccrualIncomeDtl");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.AccrualIncomeId).HasColumnName("AccrualIncomeID");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.Earncode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Hrs).HasColumnType("decimal");

                entity.Property(e => e.Salary).HasColumnType("decimal");

                entity.HasOne(d => d.AccrualIncome)
                    .WithMany(p => p.AccrualIncomeDtl)
                    .HasForeignKey(d => d.AccrualIncomeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccrualIncomeDtl_AccrualIncomeHdr");
            });

            modelBuilder.Entity<AccrualIncomeHdr>(entity =>
            {
                entity.HasKey(e => e.AccrualIncomeId)
                    .HasName("PK_AccrualIncomeHdr");

                entity.HasIndex(e => new { e.CompanyId, e.AppYear, e.AppMonth })
                    .HasName("IX_AccrualIncomeHdr")
                    .IsUnique();

                entity.Property(e => e.AccrualIncomeId)
                    .HasColumnName("AccrualIncomeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<AppChangedLog>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_AppChangedLog");

                entity.Property(e => e.Version).HasColumnType("char(10)");

                entity.Property(e => e.Changes).HasColumnType("varchar(1000)");

                entity.Property(e => e.ReleasedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.NewValue).HasColumnType("varchar(1000)");

                entity.Property(e => e.OldValue).HasColumnType("varchar(1000)");

                entity.Property(e => e.Pk)
                    .IsRequired()
                    .HasColumnName("PK")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasColumnType("char(1)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasColumnType("varchar(128)");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.BankCode)
                    .HasName("PK_Bank");

                entity.Property(e => e.BankCode).HasColumnType("char(10)");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<BankBranch>(entity =>
            {
                entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");

                entity.Property(e => e.Address1).HasColumnType("varchar(50)");

                entity.Property(e => e.Address2).HasColumnType("varchar(50)");

                entity.Property(e => e.BankCode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.BranchCode).HasColumnType("varchar(20)");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ContactPerson).HasColumnType("varchar(50)");

                entity.Property(e => e.ContactPosition).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.BankCodeNavigation)
                    .WithMany(p => p.BankBranch)
                    .HasForeignKey(d => d.BankCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BankBranch_Bank");
            });

            modelBuilder.Entity<BankSignatory>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BankSignatoryId })
                    .HasName("PK_BankSignatory");

                entity.HasIndex(e => new { e.CompanyId, e.BankSignatory1 })
                    .HasName("IX_BankSignatory")
                    .IsUnique();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.BankSignatoryId)
                    .HasColumnName("BankSignatoryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BankSignatory1)
                    .IsRequired()
                    .HasColumnName("BankSignatory")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.BankSignatoryPos)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Type).HasColumnType("varchar(10)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.BankSignatory)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BankSignatory_Company");
            });

            modelBuilder.Entity<ClientCurrentTrans>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ClientPayrollTransId })
                    .HasName("PK_ClientCurrentTrans");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.ClientPayrollTransId).HasColumnName("ClientPayrollTransID");

                entity.Property(e => e.DateInitialized).HasColumnType("datetime");

                entity.Property(e => e.InitializedBy).HasColumnType("char(15)");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Address1).HasColumnType("varchar(50)");

                entity.Property(e => e.Address2).HasColumnType("varchar(50)");

                entity.Property(e => e.ApprovingOfficer).HasColumnType("varchar(40)");

                entity.Property(e => e.CompCode).HasColumnType("varchar(50)");

                entity.Property(e => e.CompanyName).HasColumnType("varchar(50)");

                entity.Property(e => e.ContactNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.ContactPerson).HasColumnType("varchar(35)");

                entity.Property(e => e.ContactPosition).HasColumnType("varchar(30)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EmailAddress).HasColumnType("varchar(30)");

                entity.Property(e => e.EnableCustomSalarySplit).HasDefaultValueSql("0");

                entity.Property(e => e.EnableSalaryRateAddOns).HasDefaultValueSql("0");

                entity.Property(e => e.ExportFolder)
                    .HasColumnName("exportFolder")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.FaxNumber).HasColumnType("varchar(30)");

                entity.Property(e => e.Hierarchy).HasDefaultValueSql("0");

                entity.Property(e => e.HoursInputFormat)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'HH.MM60'");

                entity.Property(e => e.IncludeDeminimisInOt)
                    .HasColumnName("IncludeDeminimisInOT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MultipleEmployeeBankAcct).HasDefaultValueSql("0");

                entity.Property(e => e.OfficerPosition).HasColumnType("varchar(30)");

                entity.Property(e => e.PagibigBranchCode).HasColumnType("varchar(10)");

                entity.Property(e => e.PagibigNumber).HasColumnType("varchar(30)");

                entity.Property(e => e.PagibigSignatory).HasColumnType("varchar(40)");

                entity.Property(e => e.PagibigSignatoryPos).HasColumnType("varchar(30)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.PhilhealthNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.PhilhealthSignatory).HasColumnType("varchar(40)");

                entity.Property(e => e.PhilhealthSignatoryPos).HasColumnType("varchar(30)");

                entity.Property(e => e.Rdo)
                    .HasColumnName("RDO")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Sssnumber)
                    .HasColumnName("SSSNumber")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ssssignatory)
                    .HasColumnName("SSSSignatory")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.SsssignatoryPos)
                    .HasColumnName("SSSSignatoryPos")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Tin)
                    .HasColumnName("TIN")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tinsignatory)
                    .HasColumnName("TINSignatory")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.TinsignatoryPos)
                    .HasColumnName("TINSignatoryPos")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.W2signatory)
                    .HasColumnName("W2Signatory")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.W2signatoryPos)
                    .HasColumnName("W2SignatoryPos")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("ZIPcode")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<CompanyBank>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BankBranchId })
                    .HasName("PK_CompanyBank");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");

                entity.Property(e => e.BankAcctNumber)
                    .IsRequired()
                    .HasColumnType("char(25)");

                entity.Property(e => e.BankAcctType)
                    .IsRequired()
                    .HasColumnType("char(2)");

                entity.Property(e => e.BankDiskType).HasColumnType("varchar(10)");

                entity.Property(e => e.BranchNumber)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CorporateId)
                    .HasColumnName("CorporateID")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.BankBranch)
                    .WithMany(p => p.CompanyBank)
                    .HasForeignKey(d => d.BankBranchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CompanyBank_BankBranch");
            });

            modelBuilder.Entity<CompanySettings>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK_CompanySettings");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");
            });

            modelBuilder.Entity<ControlTotals>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.FieldName).HasColumnType("varchar(20)");

                entity.Property(e => e.NewValue).HasColumnType("decimal");

                entity.Property(e => e.OldValue).HasColumnType("decimal");

                entity.Property(e => e.Reason).HasColumnType("char(5)");
            });

            modelBuilder.Entity<CostCenter>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.Cccode })
                    .HasName("PK_CostCenter");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Cccode)
                    .HasColumnName("CCCode")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Ccdescr)
                    .HasColumnName("CCDescr")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_Currency");

                entity.Property(e => e.Code).HasColumnType("char(3)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CustomMethod>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MethodName })
                    .HasName("PK_CustomMethod");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.MethodName).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<CustomSalarySplit>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId })
                    .HasName("PK_CustomSalarySplit");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.FirstSplit).HasColumnType("decimal");

                entity.Property(e => e.SplitType)
                    .IsRequired()
                    .HasColumnType("char(3)");
            });

            modelBuilder.Entity<Dbversion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_DBVersion");

                entity.ToTable("DBVersion");

                entity.Property(e => e.Version).HasColumnType("varchar(10)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(500)");
            });

            modelBuilder.Entity<Deduction>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.EmployeeId, e.DedCode, e.TranDate })
                    .HasName("IX_Deduction")
                    .IsUnique();

                entity.Property(e => e.DeductionId).HasColumnName("DeductionID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DedAmount).HasColumnType("decimal");

                entity.Property(e => e.DedCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Frequency).HasColumnType("char(5)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PsaDedAmount)
                    .HasColumnName("psa_DedAmount")
                    .HasColumnType("decimal");

                entity.Property(e => e.RecurEnd).HasColumnType("datetime");

                entity.Property(e => e.RecurStart).HasColumnType("datetime");

                entity.Property(e => e.TranDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.HasOne(d => d.DeductionCode)
                    .WithMany(p => p.Deduction)
                    .HasForeignKey(d => new { d.CompanyId, d.DedCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Deduction_DeductionCode");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Deduction)
                    .HasForeignKey(d => new { d.CompanyId, d.EmployeeId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Deduction_Employee");
            });

            modelBuilder.Entity<DeductionCode>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DedCode })
                    .HasName("PK_DeductionCode");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DedCode).HasColumnType("char(15)");

                entity.Property(e => e.AcctCode).HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasDefaultValueSql("'PHP'");

                entity.Property(e => e.DedDescr)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DedTaxType).HasColumnType("char(6)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<DeductionFromTs>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.Tscode, e.EarnCode })
                    .HasName("PK_DeductionFromTS");

                entity.ToTable("DeductionFromTS");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Tscode)
                    .HasColumnName("TSCode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EarnCode).HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DedCodeTarget)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeductionMapping>(entity =>
            {
                entity.HasKey(e => new { e.ExternalCode, e.Dedcode })
                    .HasName("PK_DeductionMapping");

                entity.Property(e => e.ExternalCode).HasColumnType("varchar(20)");

                entity.Property(e => e.Dedcode).HasColumnType("char(15)");
            });

            modelBuilder.Entity<DeductionStaging>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.Id })
                    .HasName("PK_Deduction_Staging");

                entity.ToTable("Deduction_Staging");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DedAmount).HasColumnType("decimal");

                entity.Property(e => e.DedCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.TranDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeductionTmp>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.PayrollNo, e.EmployeeId, e.DedCode, e.Trandate })
                    .HasName("IX_DeductionTmp")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DedAmount).HasColumnType("decimal");

                entity.Property(e => e.DedCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.DeductionId).HasColumnName("DeductionID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.PayrollNo).IsRequired();

                entity.Property(e => e.PsaDedAmount)
                    .HasColumnName("psa_DedAmount")
                    .HasColumnType("decimal");

                entity.Property(e => e.Trandate)
                    .IsRequired()
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DeptCode })
                    .HasName("PK_Department");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DeptCode).HasColumnType("char(15)");

                entity.Property(e => e.DeptDescr).HasColumnType("varchar(100)");

                entity.Property(e => e.DivCode).HasColumnType("char(15)");
            });

            modelBuilder.Entity<Dependents>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK_Dependents");

                entity.HasIndex(e => new { e.CompanyId, e.EmployeeId, e.DependentName })
                    .HasName("IX_Dependents")
                    .IsUnique();

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DependentName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DivCode })
                    .HasName("PK_Division");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DivCode).HasColumnType("char(15)");

                entity.Property(e => e.DivDescr).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<DivisionSalary>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DivCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.Remarks).HasColumnType("varchar(100)");

                entity.Property(e => e.Salary).HasColumnType("decimal");
            });

            modelBuilder.Entity<Earning>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.EmployeeId, e.EarnCode, e.TranDate })
                    .HasName("IX_Earning")
                    .IsUnique();

                entity.Property(e => e.EarningId).HasColumnName("EarningID");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EarnCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Frequency).HasColumnType("char(5)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RecurEnd).HasColumnType("datetime");

                entity.Property(e => e.RecurStart).HasColumnType("datetime");

                entity.Property(e => e.TranDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.HasOne(d => d.EarningCode)
                    .WithMany(p => p.Earning)
                    .HasForeignKey(d => new { d.CompanyId, d.EarnCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Earning_EarningCode");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Earning)
                    .HasForeignKey(d => new { d.CompanyId, d.EmployeeId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Earning_Employee");
            });

            modelBuilder.Entity<EarningCode>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EarnCode })
                    .HasName("PK_EarningCode");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EarnCode).HasColumnType("char(15)");

                entity.Property(e => e.AcctCode).HasColumnType("char(15)");

                entity.Property(e => e.Bir2316)
                    .HasColumnName("BIR2316")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Birtype)
                    .HasColumnName("BIRtype")
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasDefaultValueSql("'PHP'");

                entity.Property(e => e.EarnDescr)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IncludeSss).HasColumnName("IncludeSSS");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalaryRateAddOn).HasDefaultValueSql("0");

                entity.Property(e => e.UseAddOnRateOt)
                    .HasColumnName("UseAddOnRate_OT")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EarningMapping>(entity =>
            {
                entity.HasKey(e => new { e.ExternalCode, e.Earncode })
                    .HasName("PK_EarningMapping");

                entity.Property(e => e.ExternalCode).HasColumnType("varchar(20)");

                entity.Property(e => e.Earncode).HasColumnType("char(15)");
            });

            modelBuilder.Entity<EarningStaging>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.Id })
                    .HasName("PK_Earning_Staging");

                entity.ToTable("Earning_Staging");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EarnCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.TranDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EarningTmp>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.PayrollNo, e.EmployeeId, e.EarnCode, e.Trandate })
                    .HasName("IX_EarningTmp")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EarnCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.EarningId).HasColumnName("EarningID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.PayrollNo).IsRequired();

                entity.Property(e => e.Trandate)
                    .IsRequired()
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId })
                    .HasName("PK_Employee");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.AdditionalHdmf)
                    .HasColumnName("AdditionalHDMF")
                    .HasColumnType("decimal");

                entity.Property(e => e.Address1).HasColumnType("varchar(200)");

                entity.Property(e => e.Address2).HasColumnType("varchar(50)");

                entity.Property(e => e.AllowedOt)
                    .HasColumnName("AllowedOT")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BankAcctNo).HasColumnType("varchar(20)");

                entity.Property(e => e.BankCode).HasColumnType("char(10)");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ComputeAsDaily).HasDefaultValueSql("0");

                entity.Property(e => e.Confi).HasDefaultValueSql("0");

                entity.Property(e => e.CostCenter).HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateEmployed).HasColumnType("datetime");

                entity.Property(e => e.DateRegularized).HasColumnType("datetime");

                entity.Property(e => e.DateTerminated).HasColumnType("datetime");

                entity.Property(e => e.Department).HasColumnType("char(15)");

                entity.Property(e => e.Division).HasColumnType("char(15)");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.EmployeeStatus)
                    .HasColumnType("char(10)")
                    .HasDefaultValueSql("'ACTIVE'");

                entity.Property(e => e.EmploymentType).HasColumnType("char(1)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(65)")
                    .HasComputedColumnSql("(([Lastname]+', ')+[Firstname])+'  ')+coalesce(substring([middlename],(1),(1)),''")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Gender).HasColumnType("char(1)");

                entity.Property(e => e.GrossToPrevEmployer).HasColumnType("decimal");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastWorkDate).HasColumnType("datetime");

                entity.Property(e => e.MiddleName).HasColumnType("varchar(30)");

                entity.Property(e => e.Modified).HasDefaultValueSql("1");

                entity.Property(e => e.PagibigNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.Password).HasColumnType("varchar(20)");

                entity.Property(e => e.PayCode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.PaymentType).HasColumnType("char(10)");

                entity.Property(e => e.PayrollType)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.PhilhealthNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.Position).HasColumnType("varchar(50)");

                entity.Property(e => e.PrevBasicPay).HasColumnType("decimal");

                entity.Property(e => e.PrevDeminimis).HasColumnType("decimal");

                entity.Property(e => e.PrevEmployer).HasColumnType("varchar(50)");

                entity.Property(e => e.PrevEmployerAddr).HasColumnType("varchar(30)");

                entity.Property(e => e.PrevEmployerdate).HasColumnType("datetime");

                entity.Property(e => e.PrevNt13thBonus)
                    .HasColumnName("PrevNT13thBonus")
                    .HasColumnType("decimal");

                entity.Property(e => e.PrevNtotherIncome)
                    .HasColumnName("PrevNTOtherIncome")
                    .HasColumnType("decimal");

                entity.Property(e => e.PrevSsshdmfph)
                    .HasColumnName("PrevSSSHDMFPH")
                    .HasColumnType("decimal");

                entity.Property(e => e.PrevTaxed13thBonus).HasColumnType("decimal");

                entity.Property(e => e.PrevTaxedOtherIncome).HasColumnType("decimal");

                entity.Property(e => e.PrevTin)
                    .HasColumnName("PrevTIN")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Rank).HasColumnType("char(1)");

                entity.Property(e => e.Salary).HasColumnType("decimal");

                entity.Property(e => e.Section).HasColumnType("char(15)");

                entity.Property(e => e.Sssnumber)
                    .IsRequired()
                    .HasColumnName("SSSNumber")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal");

                entity.Property(e => e.Teu)
                    .IsRequired()
                    .HasColumnName("TEU")
                    .HasColumnType("char(4)");

                entity.Property(e => e.Tin)
                    .HasColumnName("TIN")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TwoPercentRate).HasDefaultValueSql("0");

                entity.Property(e => e.WithheldToPrevEmployer).HasColumnType("decimal");

                entity.Property(e => e.ZeroHdmf)
                    .HasColumnName("ZeroHDMF")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZeroPh)
                    .HasColumnName("ZeroPH")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZeroSss)
                    .HasColumnName("ZeroSSS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZeroTax).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EmployeeBankAccounts>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.BankAcctNumber })
                    .HasName("PK_EmployeeBankAccount");

                entity.HasIndex(e => new { e.CompanyId, e.EmployeeId, e.SalaryDistributionPriority })
                    .HasName("IX_EmployeeBankAccounts_priority")
                    .IsUnique();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.BankAcctNumber).HasColumnType("varchar(25)");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalaryDistributionFixAmt).HasColumnType("decimal");

                entity.Property(e => e.SalaryDistributionType)
                    .IsRequired()
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<EmployeeBr>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.Otcode })
                    .HasName("PK_EmployeeBR");

                entity.ToTable("EmployeeBR");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Otcode)
                    .HasColumnName("OTCode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Ot8rate)
                    .HasColumnName("OT8Rate")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Otrate)
                    .HasColumnName("OTRate")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OtrateNd1)
                    .HasColumnName("OTRateND1")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EmployeeDepository>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId })
                    .HasName("PK_EmployeeDepository");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");

                entity.HasOne(d => d.BankBranch)
                    .WithMany(p => p.EmployeeDepository)
                    .HasForeignKey(d => d.BankBranchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeDepository_EmployeeDepository");

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.EmployeeDepository)
                    .HasForeignKey<EmployeeDepository>(d => new { d.CompanyId, d.EmployeeId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeDepository_Employee");
            });

            modelBuilder.Entity<EmployeeFixedShare>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId })
                    .HasName("PK_EmployeeFixedShare");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeePagibig).HasColumnType("decimal");

                entity.Property(e => e.EmployeePh)
                    .HasColumnName("EmployeePH")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployeeSss)
                    .HasColumnName("EmployeeSSS")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerEcc)
                    .HasColumnName("EmployerECC")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerPagibig).HasColumnType("decimal");

                entity.Property(e => e.EmployerPh)
                    .HasColumnName("EmployerPH")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerSss)
                    .HasColumnName("EmployerSSS")
                    .HasColumnType("decimal");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<EmployeeJvcode>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId })
                    .HasName("PK_EmployeeJVcode");

                entity.ToTable("EmployeeJVcode");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Jvcode)
                    .HasColumnName("JVcode")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<EmployeeOtherInfo>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId })
                    .HasName("PK_EmployeeOtherInfo");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.ExtraColumn1).HasColumnType("varchar(30)");

                entity.Property(e => e.ExtraColumn2).HasColumnType("varchar(30)");

                entity.Property(e => e.ExtraColumn3).HasColumnType("varchar(30)");

                entity.Property(e => e.ExtraColumn4).HasColumnType("varchar(30)");

                entity.Property(e => e.ExtraColumn5).HasColumnType("varchar(500)");

                entity.Property(e => e.ExtraColumn6).HasColumnType("varchar(30)");

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.EmployeeOtherInfo)
                    .HasForeignKey<EmployeeOtherInfo>(d => new { d.CompanyId, d.EmployeeId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeOtherInfo_Employee");
            });

            modelBuilder.Entity<EmployeeQueue>(entity =>
            {
                entity.HasIndex(e => new { e.JobType, e.ReportType, e.CompanyId, e.RefNo, e.EmployeeId })
                    .HasName("IX_EmployeeQueue")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Remarks).HasColumnType("varchar(500)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.StatusDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<EmployeeStaging>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.Id })
                    .HasName("PK_Employee_staging");

                entity.ToTable("Employee_staging");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdditionalHdmf)
                    .HasColumnName("AdditionalHDMF")
                    .HasColumnType("decimal");

                entity.Property(e => e.Address1).HasColumnType("varchar(200)");

                entity.Property(e => e.Address2).HasColumnType("varchar(200)");

                entity.Property(e => e.AllowedOt).HasColumnName("AllowedOT");

                entity.Property(e => e.BankAcctNo).HasColumnType("varchar(20)");

                entity.Property(e => e.BankCode).HasColumnType("char(10)");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CostCenter).HasColumnType("varchar(50)");

                entity.Property(e => e.DateEmployed).HasColumnType("datetime");

                entity.Property(e => e.DateRegularized).HasColumnType("datetime");

                entity.Property(e => e.DateTerminated).HasColumnType("datetime");

                entity.Property(e => e.Department).HasColumnType("varchar(50)");

                entity.Property(e => e.DeptDescr).HasColumnType("varchar(100)");

                entity.Property(e => e.Division).HasColumnType("varchar(50)");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.EmployeeStatus).HasColumnType("varchar(50)");

                entity.Property(e => e.EmploymentType).HasColumnType("char(1)");

                entity.Property(e => e.ExtraColumn1).HasColumnType("varchar(30)");

                entity.Property(e => e.ExtraColumn2).HasColumnType("varchar(30)");

                entity.Property(e => e.ExtraColumn3).HasColumnType("varchar(30)");

                entity.Property(e => e.ExtraColumn4).HasColumnType("varchar(30)");

                entity.Property(e => e.ExtraColumn5).HasColumnType("varchar(500)");

                entity.Property(e => e.ExtraColumn6).HasColumnType("varchar(30)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(30)");

                entity.Property(e => e.Gender).HasColumnType("varchar(10)");

                entity.Property(e => e.LastName).HasColumnType("varchar(30)");

                entity.Property(e => e.LastWorkDate).HasColumnType("varchar(50)");

                entity.Property(e => e.MiddleName).HasColumnType("varchar(30)");

                entity.Property(e => e.PagibigNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.Password).HasColumnType("varchar(20)");

                entity.Property(e => e.PayCode).HasColumnType("varchar(20)");

                entity.Property(e => e.PaymentType).HasColumnType("varchar(50)");

                entity.Property(e => e.PayrollType).HasColumnType("varchar(10)");

                entity.Property(e => e.PhilhealthNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.Position).HasColumnType("varchar(50)");

                entity.Property(e => e.Rank).HasColumnType("char(1)");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Salary).HasColumnType("decimal");

                entity.Property(e => e.Section).HasColumnType("varchar(50)");

                entity.Property(e => e.Sssnumber)
                    .HasColumnName("SSSNumber")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal");

                entity.Property(e => e.Teu)
                    .HasColumnName("TEU")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Tin)
                    .HasColumnName("TIN")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ZeroHdmf).HasColumnName("ZeroHDMF");

                entity.Property(e => e.ZeroPh).HasColumnName("ZeroPH");

                entity.Property(e => e.ZeroSss).HasColumnName("ZeroSSS");
            });

            modelBuilder.Entity<EmployeeStatus>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_EmployeeStatus");

                entity.Property(e => e.Code).HasColumnType("char(10)");

                entity.Property(e => e.Description).HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<EmployeeYearEnd>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.Year, e.EmployeeId })
                    .HasName("PK_EmployeeYearEnd");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.DateRefreshed).HasColumnType("smalldatetime");

                entity.Property(e => e.Department).HasColumnType("char(15)");

                entity.Property(e => e.Paycode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.Teu)
                    .IsRequired()
                    .HasColumnName("TEU")
                    .HasColumnType("char(4)");
            });

            modelBuilder.Entity<EmployeesAid>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.EmployeeId })
                    .HasName("PK_Employees_aid");

                entity.ToTable("Employees_aid");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");
            });

            modelBuilder.Entity<EmploymentType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_EmploymentType");

                entity.Property(e => e.Code).HasColumnType("char(1)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<ExcelError>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Message).HasColumnType("varchar(1000)");
            });

            modelBuilder.Entity<GeneralSettings>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.Key })
                    .HasName("PK_GeneralSettings");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Key).HasColumnType("varchar(50)");

                entity.Property(e => e.Description).HasColumnType("varchar(1000)");

                entity.Property(e => e.ShortName).HasColumnType("varchar(100)");

                entity.Property(e => e.Value).HasColumnType("varchar(500)");
            });

            modelBuilder.Entity<GlAccount>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.AcctCode })
                    .HasName("PK_GL_Account");

                entity.ToTable("GL_Account");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.AcctCode).HasColumnType("char(15)");

                entity.Property(e => e.AcctDescr)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Drcr)
                    .HasColumnName("DRCR")
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<GltranAcctCode>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.TranId })
                    .HasName("PK_GLTran_AcctCode_1");

                entity.ToTable("GLTran_AcctCode");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TranId)
                    .HasColumnName("TranID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.AcctCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.Drcr)
                    .IsRequired()
                    .HasColumnName("DRCR")
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<GovBasis>(entity =>
            {
                entity.HasKey(e => e.BasisCode)
                    .HasName("PK_GovBasis");

                entity.Property(e => e.BasisCode).HasColumnType("char(5)");

                entity.Property(e => e.BasisName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<GovPayment>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ApplicableYear, e.ApplicableMonth })
                    .HasName("PK_GovPayment");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.PagOrAmount)
                    .HasColumnName("PAG_OR_Amount")
                    .HasColumnType("decimal");

                entity.Property(e => e.PagOrDate)
                    .HasColumnName("PAG_OR_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PagOrNo)
                    .HasColumnName("PAG_OR_NO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.PhOrAmount)
                    .HasColumnName("PH_OR_Amount")
                    .HasColumnType("decimal");

                entity.Property(e => e.PhOrDate)
                    .HasColumnName("PH_OR_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PhOrNo)
                    .HasColumnName("PH_OR_NO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.SssOrAmount)
                    .HasColumnName("SSS_OR_Amount")
                    .HasColumnType("decimal");

                entity.Property(e => e.SssOrDate)
                    .HasColumnName("SSS_OR_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SssOrNo)
                    .HasColumnName("SSS_OR_NO")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<InactiveEmployees>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.PayrollNo })
                    .HasName("PK_InactiveEmployees");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.EmployeeStatus)
                    .IsRequired()
                    .HasColumnType("char(10)");
            });

            modelBuilder.Entity<IncomeFromOt>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.Otcode, e.EarnCode })
                    .HasName("PK_IncomeFromOT");

                entity.ToTable("IncomeFromOT");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Otcode)
                    .HasColumnName("OTCode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EarnCode).HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EarnCodeTarget)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Jvacct>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.AcctCode })
                    .HasName("PK_JVAcct");

                entity.ToTable("JVAcct");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.AcctCode).HasColumnType("char(20)");

                entity.Property(e => e.AcctCode2).HasColumnType("varchar(50)");

                entity.Property(e => e.AcctDescr).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Drcr)
                    .IsRequired()
                    .HasColumnName("DRCR")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Presentation)
                    .IsRequired()
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<JvacctDtl>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.AcctCode, e.SubAcctCode })
                    .HasName("PK_JVAcctDtl");

                entity.ToTable("JVAcctDtl");

                entity.HasIndex(e => new { e.CompanyId, e.AcctCode, e.EmployeeDeptId })
                    .HasName("IX_JVAcctDtl_acct_empid");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.AcctCode).HasColumnType("char(20)");

                entity.Property(e => e.SubAcctCode).HasColumnType("char(20)");

                entity.Property(e => e.EmployeeDeptId)
                    .IsRequired()
                    .HasColumnName("EmployeeDeptID")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Jvreport>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK_JVReport");

                entity.ToTable("JVReport");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.AcctCode).HasColumnType("char(15)");

                entity.Property(e => e.AcctDescr).HasColumnType("varchar(100)");

                entity.Property(e => e.Cr)
                    .HasColumnName("CR")
                    .HasColumnType("decimal");

                entity.Property(e => e.Department).HasColumnType("varchar(200)");

                entity.Property(e => e.Dr)
                    .HasColumnName("DR")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmpJvcode)
                    .HasColumnName("EmpJVcode")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<LeaveBalance>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PayrollNo, e.EmployeeId, e.LeaveCode })
                    .HasName("PK_LeaveBalance");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.LeaveCode).HasColumnType("char(10)");

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LeaveHdr>(entity =>
            {
                entity.Property(e => e.LeaveHdrId).HasColumnName("LeaveHdrID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasDefaultValueSql("1");

                entity.Property(e => e.Remarks).HasColumnType("varchar(50)");

                entity.Property(e => e.TranDate).HasColumnType("datetime");

                entity.Property(e => e.TranType)
                    .IsRequired()
                    .HasColumnType("char(3)");
            });

            modelBuilder.Entity<LeaveTran>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.LeaveHdrId).HasColumnName("LeaveHdrID");

                entity.Property(e => e.Modified).HasDefaultValueSql("1");

                entity.Property(e => e.Sl)
                    .HasColumnName("SL")
                    .HasColumnType("decimal");

                entity.Property(e => e.Vl)
                    .HasColumnName("VL")
                    .HasColumnType("decimal");
            });

            modelBuilder.Entity<LeaveTranTmp>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.PayrollNo })
                    .HasName("PK_LeaveTranTmp");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy).HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("varchar(50)");

                entity.Property(e => e.Sl)
                    .HasColumnName("SL")
                    .HasColumnType("decimal");

                entity.Property(e => e.Vl)
                    .HasColumnName("VL")
                    .HasColumnType("decimal");
            });

            modelBuilder.Entity<LeaveType>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK_LeaveType");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SlEarn)
                    .HasColumnName("SL_earn")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SlFreq)
                    .IsRequired()
                    .HasColumnName("SL_freq")
                    .HasColumnType("char(1)");

                entity.Property(e => e.SlYearlyCredit)
                    .HasColumnName("SL_YearlyCredit")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VlEarn)
                    .HasColumnName("VL_earn")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VlFreq)
                    .IsRequired()
                    .HasColumnName("VL_freq")
                    .HasColumnType("char(1)");

                entity.Property(e => e.VlYearlyCredit)
                    .HasColumnName("VL_YearlyCredit")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LeaveTypes>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.LeaveCode })
                    .HasName("PK_LeaveTypes");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.LeaveCode).HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Earning).HasColumnType("decimal");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.EmployeeId, e.LoanCode, e.ApprovedDate })
                    .HasName("IX_Loan")
                    .IsUnique();

                entity.Property(e => e.LoanId).HasColumnName("LoanID");

                entity.Property(e => e.Amortization).HasColumnType("decimal");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Balance).HasColumnType("decimal");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeductAmount).HasColumnType("decimal");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasColumnType("char(5)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LoanCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.Modified).HasDefaultValueSql("1");

                entity.Property(e => e.Principal).HasColumnType("decimal");

                entity.Property(e => e.Remarks).HasColumnType("varchar(50)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TotalPayments).HasColumnType("decimal");

                entity.Property(e => e.WithInterest).HasColumnType("decimal");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Loan)
                    .HasForeignKey(d => new { d.CompanyId, d.EmployeeId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Loan_Employee");

                entity.HasOne(d => d.LoanCodeNavigation)
                    .WithMany(p => p.Loan)
                    .HasForeignKey(d => new { d.CompanyId, d.LoanCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Loan_LoanCode");
            });

            modelBuilder.Entity<LoanCode>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.LoanCode1 })
                    .HasName("PK_LoanCode");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.LoanCode1)
                    .HasColumnName("LoanCode")
                    .HasColumnType("char(15)");

                entity.Property(e => e.AcctCode).HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Currency).HasColumnType("char(3)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LoanDescr)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LoanType)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'O'");
            });

            modelBuilder.Entity<LoanStaging>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.RowId })
                    .HasName("PK_Loan_Staging");

                entity.ToTable("Loan_Staging");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Amortization).HasColumnType("decimal");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Balance).HasColumnType("decimal");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DeductAmount).HasColumnType("decimal");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Frequency).HasColumnType("char(5)");

                entity.Property(e => e.LoanCode).HasColumnType("char(15)");

                entity.Property(e => e.Principal).HasColumnType("decimal");

                entity.Property(e => e.Remarks).HasColumnType("varchar(50)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TotalPayments).HasColumnType("decimal");

                entity.Property(e => e.WithInterest).HasColumnType("decimal");
            });

            modelBuilder.Entity<LoanSumm>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.EmployeeId, e.LoanCode, e.ApprovedDate, e.PayrollNo, e.PayDate })
                    .HasName("IX_LoanSumm")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Balance).HasColumnType("decimal");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeductAmount).HasColumnType("decimal");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LoanCode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.LoanId).HasColumnName("LoanID");

                entity.Property(e => e.Modified).HasDefaultValueSql("1");

                entity.Property(e => e.PayDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Principal).HasColumnType("decimal");

                entity.Property(e => e.PsaDeductAmount)
                    .HasColumnName("psa_DeductAmount")
                    .HasColumnType("decimal");

                entity.Property(e => e.Remarks).HasColumnType("varchar(30)");

                entity.Property(e => e.TotalPayments).HasColumnType("decimal");

                entity.Property(e => e.WithInterest).HasColumnType("decimal");
            });

            modelBuilder.Entity<LoanTmp>(entity =>
            {
                entity.HasKey(e => new { e.LoanId, e.PayrollNo })
                    .HasName("PK_LoanTmp");

                entity.Property(e => e.LoanId).HasColumnName("LoanID");

                entity.Property(e => e.Balance).HasColumnType("decimal");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DeductAmount).HasColumnType("decimal");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.LoanCode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.Principal).HasColumnType("decimal");

                entity.Property(e => e.PsaDeductAmount)
                    .HasColumnName("psa_DeductAmount")
                    .HasColumnType("decimal");

                entity.Property(e => e.Remarks).HasColumnType("varchar(30)");

                entity.Property(e => e.TotalPayments).HasColumnType("decimal");

                entity.Property(e => e.WithInterest).HasColumnType("decimal");
            });

            modelBuilder.Entity<MailQueue>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PayrollNo, e.EmployeeId })
                    .HasName("PK_MailQueue");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Remarks).HasColumnType("varchar(500)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.StatusDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MailQueue2>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.Year, e.EmployeeId })
                    .HasName("PK_MailQueue2");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Remarks).HasColumnType("varchar(500)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.StatusDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Months>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PK_Months");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cmonth)
                    .HasColumnName("cmonth")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<MtaxTable>(entity =>
            {
                entity.HasKey(e => e.Exemption)
                    .HasName("PK_MTaxTable");

                entity.ToTable("MTaxTable");

                entity.Property(e => e.Exemption).HasColumnType("char(4)");

                entity.Property(e => e.Amount1).HasColumnType("decimal");

                entity.Property(e => e.Amount2).HasColumnType("decimal");

                entity.Property(e => e.Amount3).HasColumnType("decimal");

                entity.Property(e => e.Amount4).HasColumnType("decimal");

                entity.Property(e => e.Amount5).HasColumnType("decimal");

                entity.Property(e => e.Amount6).HasColumnType("decimal");

                entity.Property(e => e.Amount7).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Otcode>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.Otcode1 })
                    .HasName("PK_OTCode");

                entity.ToTable("OTCode");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Otcode1)
                    .HasColumnName("OTCode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ot8brate)
                    .HasColumnName("OT8BRate")
                    .HasColumnType("decimal");

                entity.Property(e => e.Ot8rate)
                    .HasColumnName("OT8Rate")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otbrate)
                    .HasColumnName("OTBRate")
                    .HasColumnType("decimal");

                entity.Property(e => e.OtbrateNd1)
                    .HasColumnName("OTBRateND1")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otdescription)
                    .IsRequired()
                    .HasColumnName("OTDescription")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Otrate)
                    .HasColumnName("OTRate")
                    .HasColumnType("decimal");

                entity.Property(e => e.OtrateNd1)
                    .HasColumnName("OTRateND1")
                    .HasColumnType("decimal");

                entity.Property(e => e.OtrateNd2)
                    .HasColumnName("OTRateND2")
                    .HasColumnType("decimal");
            });

            modelBuilder.Entity<Otsheet>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.Otcode })
                    .HasName("PK_OTSheet");

                entity.ToTable("OTSheet");

                entity.HasIndex(e => e.OtsheetId)
                    .HasName("IX_OTSheet")
                    .IsUnique();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Otcode)
                    .HasColumnName("OTCode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CostCenter).HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Frequency).HasColumnType("varchar(20)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ot8hours)
                    .HasColumnName("OT8Hours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Othours)
                    .HasColumnName("OTHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otnd2hours)
                    .HasColumnName("OTND2Hours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otndhours)
                    .HasColumnName("OTNDHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.OtsheetId)
                    .HasColumnName("OTSheetID")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.OtcodeNavigation)
                    .WithMany(p => p.Otsheet)
                    .HasForeignKey(d => new { d.CompanyId, d.Otcode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OTSheet_OTCode");
            });

            modelBuilder.Entity<OtsheetStaging>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.Id })
                    .HasName("PK_OTSheet_Staging");

                entity.ToTable("OTSheet_Staging");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Ot8hours)
                    .HasColumnName("OT8Hours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otcode)
                    .IsRequired()
                    .HasColumnName("OTCode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Othours)
                    .HasColumnName("OTHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otnd2hours)
                    .HasColumnName("OTND2Hours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otndhours)
                    .HasColumnName("OTNDHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.RowId).HasColumnName("RowID");
            });

            modelBuilder.Entity<OtsheetTmp>(entity =>
            {
                entity.HasKey(e => e.OtsheetId)
                    .HasName("PK_OTSheetTmp");

                entity.ToTable("OTSheetTmp");

                entity.Property(e => e.OtsheetId)
                    .HasColumnName("OTSheetID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CostCenter).HasColumnType("char(15)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Frequency).HasColumnType("varchar(20)");

                entity.Property(e => e.Nd1amt)
                    .HasColumnName("ND1Amt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Nd2amt)
                    .HasColumnName("ND2Amt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Ot8amt)
                    .HasColumnName("OT8Amt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Ot8hours)
                    .HasColumnName("OT8Hours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otamt)
                    .HasColumnName("OTAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otcode)
                    .IsRequired()
                    .HasColumnName("OTCode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Othours)
                    .HasColumnName("OTHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otnd2hours)
                    .HasColumnName("OTND2Hours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Otndhours)
                    .HasColumnName("OTNDHours")
                    .HasColumnType("decimal");
            });

            modelBuilder.Entity<OvertimeMapping>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.TranId })
                    .HasName("PK_OvertimeMapping");

                entity.HasIndex(e => new { e.CompanyId, e.Otcode, e.Ottype })
                    .HasName("IX_OvertimeMapping")
                    .IsUnique();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TranId)
                    .HasColumnName("TranID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.AcctCode).HasColumnType("char(15)");

                entity.Property(e => e.Description).HasColumnType("varchar(100)");

                entity.Property(e => e.Otcode)
                    .IsRequired()
                    .HasColumnName("OTcode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Ottype).HasColumnName("OTtype");

                entity.Property(e => e.ShortName).HasColumnType("varchar(30)");

                entity.HasOne(d => d.OtcodeNavigation)
                    .WithMany(p => p.OvertimeMapping)
                    .HasForeignKey(d => new { d.CompanyId, d.Otcode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OvertimeMapping_OTCode");
            });

            modelBuilder.Entity<PatchHistory>(entity =>
            {
                entity.HasKey(e => e.PatchId)
                    .HasName("PK_PatchHistory_1");

                entity.Property(e => e.PatchId).ValueGeneratedNever();

                entity.Property(e => e.AppVersion).HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PatchDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasColumnType("varchar(1000)");
            });

            modelBuilder.Entity<PayBackup>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PayrollNo })
                    .HasName("PK_PayBackup_1");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.BackupDate).HasColumnType("datetime");

                entity.Property(e => e.BackupFileName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasColumnType("char(10)");
            });

            modelBuilder.Entity<PayCode>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PayCode1 })
                    .HasName("PK_PayCode");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.PayCode1)
                    .HasColumnName("PayCode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.BpLessSl).HasColumnName("BpLessSL");

                entity.Property(e => e.BpLessSl2).HasColumnName("BpLessSL2");

                entity.Property(e => e.BpLessUt).HasColumnName("BpLessUT");

                entity.Property(e => e.BpLessUt2).HasColumnName("BpLessUT2");

                entity.Property(e => e.BpLessVl).HasColumnName("BpLessVL");

                entity.Property(e => e.BpLessVl2).HasColumnName("BpLessVL2");

                entity.Property(e => e.CompXpayHoli)
                    .HasColumnName("CompXPayHoli")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ExportFolder)
                    .HasColumnName("exportFolder")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.HrsPerDay).HasColumnType("decimal");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MinimumWager).HasDefaultValueSql("0");

                entity.Property(e => e.Nd1rate)
                    .HasColumnName("ND1rate")
                    .HasColumnType("decimal");

                entity.Property(e => e.Nd2rate)
                    .HasColumnName("ND2rate")
                    .HasColumnType("decimal");

                entity.Property(e => e.NetPayLevelBasis).HasColumnType("varchar(15)");

                entity.Property(e => e.PagibigAmtSplit).HasDefaultValueSql("0");

                entity.Property(e => e.PagibigBasis)
                    .IsRequired()
                    .HasColumnType("char(5)");

                entity.Property(e => e.PagibigFreq)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.PayrollFreq)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.PhilhealthBasis)
                    .IsRequired()
                    .HasColumnType("char(5)");

                entity.Property(e => e.PhilhealthFreq)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.SalaryRateHasAddOns).HasDefaultValueSql("0");

                entity.Property(e => e.Sssbasis)
                    .IsRequired()
                    .HasColumnName("SSSBasis")
                    .HasColumnType("char(5)");

                entity.Property(e => e.SssbasisDays).HasColumnName("SSSBasisDays");

                entity.Property(e => e.Sssfrequency)
                    .IsRequired()
                    .HasColumnName("SSSFrequency")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TaxMethod)
                    .IsRequired()
                    .HasColumnType("char(6)");

                entity.Property(e => e.TaxTable).HasColumnType("char(1)");

                entity.Property(e => e.TaxableOt).HasColumnName("TaxableOT");

                entity.Property(e => e.WorkingDays).HasColumnType("decimal");

                entity.Property(e => e.ZeroTax).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PayMast>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId })
                    .HasName("PK_PayMast");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.AdditionalHdmf)
                    .HasColumnName("AdditionalHDMF")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BankAcctNo).HasColumnType("varchar(20)");

                entity.Property(e => e.BankCode).HasColumnType("char(10)");

                entity.Property(e => e.BasicPay).HasColumnType("decimal");

                entity.Property(e => e.CostCenter).HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DailyRate).HasColumnType("decimal");

                entity.Property(e => e.DedTaxAmt).HasColumnType("decimal");

                entity.Property(e => e.DeductionAmt).HasColumnType("decimal");

                entity.Property(e => e.Department).HasColumnType("char(15)");

                entity.Property(e => e.Division).HasColumnType("char(15)");

                entity.Property(e => e.EmployeePagibig).HasColumnType("decimal");

                entity.Property(e => e.EmployeePh)
                    .HasColumnName("EmployeePH")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployeeSss)
                    .HasColumnName("EmployeeSSS")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerEcc)
                    .HasColumnName("EmployerECC")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerPagibig).HasColumnType("decimal");

                entity.Property(e => e.EmployerPh)
                    .HasColumnName("EmployerPH")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerSss)
                    .HasColumnName("EmployerSSS")
                    .HasColumnType("decimal");

                entity.Property(e => e.GrossPay).HasColumnType("decimal");

                entity.Property(e => e.HourlyRate).HasColumnType("decimal");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LoanAmt).HasColumnType("decimal");

                entity.Property(e => e.NetBasic).HasColumnType("decimal");

                entity.Property(e => e.NetBasic13thM).HasColumnType("decimal");

                entity.Property(e => e.NetPay).HasColumnType("decimal");

                entity.Property(e => e.NtxEarning).HasColumnType("decimal");

                entity.Property(e => e.Otamt)
                    .HasColumnName("OTAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Paycode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.Salary).HasColumnType("decimal");

                entity.Property(e => e.Section).HasColumnType("char(15)");

                entity.Property(e => e.Teu)
                    .IsRequired()
                    .HasColumnName("TEU")
                    .HasColumnType("char(4)");

                entity.Property(e => e.TimesheetAmt).HasColumnType("decimal");

                entity.Property(e => e.TxEarning).HasColumnType("decimal");

                entity.Property(e => e.Wtax)
                    .HasColumnName("WTax")
                    .HasColumnType("decimal");
            });

            modelBuilder.Entity<PayPeriod>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PayrollNo })
                    .HasName("PK_PayPeriod");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.PayrollNo).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Currency).HasColumnType("char(3)");

                entity.Property(e => e.CutOffFrom).HasColumnType("datetime");

                entity.Property(e => e.CutOffTo).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal");

                entity.Property(e => e.ExportedByProvider).HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayrollFreq)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.PayrollStatus).HasColumnType("char(10)");

                entity.Property(e => e.PeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");

                entity.Property(e => e.ProcessType)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Remarks).HasColumnType("varchar(500)");

                entity.Property(e => e.WeekNo)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.HasOne(d => d.CurrencyNavigation)
                    .WithMany(p => p.PayPeriod)
                    .HasForeignKey(d => d.Currency)
                    .HasConstraintName("FK_PayPeriod_Currency");
            });

            modelBuilder.Entity<PayPeriodStaging>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.RowId })
                    .HasName("PK_PayPeriod_Staging");

                entity.ToTable("PayPeriod_Staging");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.CutOffFrom).HasColumnType("datetime");

                entity.Property(e => e.CutOffTo).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayrollFreq).HasColumnType("char(1)");

                entity.Property(e => e.PayrollStatus).HasColumnType("char(10)");

                entity.Property(e => e.PeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");

                entity.Property(e => e.ProcessType).HasColumnType("varchar(20)");

                entity.Property(e => e.Remarks).HasColumnType("varchar(500)");

                entity.Property(e => e.WeekNo).HasColumnType("char(1)");
            });

            modelBuilder.Entity<PayrollFreq>(entity =>
            {
                entity.HasKey(e => e.FreqCode)
                    .HasName("PK_Frequency");

                entity.Property(e => e.FreqCode).HasColumnType("char(1)");

                entity.Property(e => e.FreqDescr)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PayrollTestCases>(entity =>
            {
                entity.HasKey(e => e.TestNo)
                    .HasName("PK_PayCodeTests");

                entity.Property(e => e.BonusBasis).HasColumnType("varchar(15)");

                entity.Property(e => e.BonusBasisCb)
                    .HasColumnName("BonusBasisCB")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.BpLessSl).HasColumnName("BpLessSL");

                entity.Property(e => e.BpLessSl2).HasColumnName("BpLessSL2");

                entity.Property(e => e.BpLessUt).HasColumnName("BpLessUT");

                entity.Property(e => e.BpLessUt2).HasColumnName("BpLessUT2");

                entity.Property(e => e.BpLessVl).HasColumnName("BpLessVL");

                entity.Property(e => e.BpLessVl2).HasColumnName("BpLessVL2");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.OtTimeFormat)
                    .HasColumnName("OT_TimeFormat")
                    .HasColumnType("char(1)");

                entity.Property(e => e.PagibigBasis).HasColumnType("char(5)");

                entity.Property(e => e.PagibigFreq).HasColumnType("char(10)");

                entity.Property(e => e.PayCode).HasColumnType("char(10)");

                entity.Property(e => e.PayrollFreq).HasColumnType("char(1)");

                entity.Property(e => e.PhilhealthBasis).HasColumnType("char(5)");

                entity.Property(e => e.PhilhealthFreq).HasColumnType("char(10)");

                entity.Property(e => e.ProcessType).HasColumnType("varchar(20)");

                entity.Property(e => e.Sssbasis)
                    .HasColumnName("SSSBasis")
                    .HasColumnType("char(5)");

                entity.Property(e => e.SssbasisDays).HasColumnName("SSSBasisDays");

                entity.Property(e => e.Sssfrequency)
                    .HasColumnName("SSSFrequency")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TaxMethod).HasColumnType("char(6)");

                entity.Property(e => e.TaxTable).HasColumnType("char(1)");

                entity.Property(e => e.TaxableOt).HasColumnName("TaxableOT");

                entity.Property(e => e.TsTimeFormat)
                    .HasColumnName("TS_TimeFormat")
                    .HasColumnType("char(1)");

                entity.Property(e => e.WorkingDays).HasColumnType("decimal");
            });

            modelBuilder.Entity<PayrollTestResults>(entity =>
            {
                entity.HasKey(e => new { e.TestNo, e.CompanyId, e.EmployeeId })
                    .HasName("PK_PayrollTestResults");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.BankAcctNo).HasColumnType("varchar(20)");

                entity.Property(e => e.BankCode).HasColumnType("char(10)");

                entity.Property(e => e.BasicPay).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DailyRate).HasColumnType("decimal");

                entity.Property(e => e.DedTaxAmt).HasColumnType("decimal");

                entity.Property(e => e.DeductionAmt).HasColumnType("decimal");

                entity.Property(e => e.Department).HasColumnType("char(15)");

                entity.Property(e => e.Division).HasColumnType("char(15)");

                entity.Property(e => e.EmployeePagibig).HasColumnType("decimal");

                entity.Property(e => e.EmployeePh)
                    .HasColumnName("EmployeePH")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployeeSss)
                    .HasColumnName("EmployeeSSS")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerEcc)
                    .HasColumnName("EmployerECC")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerPagibig).HasColumnType("decimal");

                entity.Property(e => e.EmployerPh)
                    .HasColumnName("EmployerPH")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerSss)
                    .HasColumnName("EmployerSSS")
                    .HasColumnType("decimal");

                entity.Property(e => e.GrossPay).HasColumnType("decimal");

                entity.Property(e => e.HourlyRate).HasColumnType("decimal");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LoanAmt).HasColumnType("decimal");

                entity.Property(e => e.NetBasic).HasColumnType("decimal");

                entity.Property(e => e.NetBasic13thM).HasColumnType("decimal");

                entity.Property(e => e.NetPay).HasColumnType("decimal");

                entity.Property(e => e.NtxEarning).HasColumnType("decimal");

                entity.Property(e => e.Otamt)
                    .HasColumnName("OTAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Paycode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.Section).HasColumnType("char(15)");

                entity.Property(e => e.Teu)
                    .IsRequired()
                    .HasColumnName("TEU")
                    .HasColumnType("char(4)");

                entity.Property(e => e.TimesheetAmt).HasColumnType("decimal");

                entity.Property(e => e.TxEarning).HasColumnType("decimal");

                entity.Property(e => e.Wtax)
                    .HasColumnName("WTax")
                    .HasColumnType("decimal");
            });

            modelBuilder.Entity<PayrollType>(entity =>
            {
                entity.HasKey(e => e.PayrollType1)
                    .HasName("PK_PayrollType");

                entity.Property(e => e.PayrollType1)
                    .HasColumnName("PayrollType")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PhilhealthTable>(entity =>
            {
                entity.HasIndex(e => e.EmployeePh)
                    .HasName("IX_PhilhealthTable_eeshare");

                entity.HasIndex(e => e.LowerLimit)
                    .HasName("IX_PhilhealthTable")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseSalary)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bracket)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeePh)
                    .HasColumnName("EmployeePH")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerPh)
                    .HasColumnName("EmployerPH")
                    .HasColumnType("decimal");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LowerLimit).HasColumnType("decimal");

                entity.Property(e => e.Total).HasColumnType("decimal");

                entity.Property(e => e.UpperLimit).HasColumnType("decimal");
            });

            modelBuilder.Entity<Pivot>(entity =>
            {
                entity.HasKey(e => e.I)
                    .HasName("PK_Pivot");

                entity.Property(e => e.I)
                    .HasColumnName("i")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ProcessException>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.Remarks).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<ProcessOptions>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PayrollNo })
                    .HasName("PK_ProcessOptions");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.AdjustPob).HasColumnName("AdjustPOB");

                entity.Property(e => e.BonusBasis).HasColumnType("varchar(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CurrBasicMethod)
                    .HasColumnName("currBasicMethod")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.EarningFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.EarningTo).HasColumnType("smalldatetime");

                entity.Property(e => e.IsFinalTax).HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NtxEarncode)
                    .HasColumnName("NTxEarncode")
                    .HasColumnType("char(10)");

                entity.Property(e => e.PaymasFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PaymasTo).HasColumnType("smalldatetime");

                entity.Property(e => e.TaxMethod).HasColumnType("char(6)");

                entity.Property(e => e.TxEarncode).HasColumnType("char(10)");
            });

            modelBuilder.Entity<ProrateOt>(entity =>
            {
                entity.HasKey(e => e.ProrateId)
                    .HasName("PK_ProrateOT");

                entity.ToTable("ProrateOT");

                entity.Property(e => e.ProrateId).HasColumnName("ProrateID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EarnCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.Otcode)
                    .IsRequired()
                    .HasColumnName("OTCode")
                    .HasColumnType("char(10)");
            });

            modelBuilder.Entity<ProrateTs>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EarnCode })
                    .HasName("PK_ProrateTS");

                entity.ToTable("ProrateTS");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EarnCode).HasColumnType("char(15)");

                entity.Property(e => e.ProAbs).HasColumnName("Pro_Abs");

                entity.Property(e => e.ProBackPaySl).HasColumnName("Pro_BackPaySL");

                entity.Property(e => e.ProBackPayVl).HasColumnName("Pro_BackPayVL");

                entity.Property(e => e.ProPaidHoli).HasColumnName("Pro_PaidHoli");

                entity.Property(e => e.ProReg).HasColumnName("Pro_Reg");

                entity.Property(e => e.ProSl).HasColumnName("Pro_SL");

                entity.Property(e => e.ProTardy).HasColumnName("Pro_Tardy");

                entity.Property(e => e.ProUt).HasColumnName("Pro_UT");

                entity.Property(e => e.ProVl).HasColumnName("Pro_VL");
            });

            modelBuilder.Entity<ProratedEarning>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.EarnCode, e.BaseTable, e.BaseCode })
                    .HasName("IX_ProratedEarning")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseCode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.BaseTable)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.ComputeMonthlyAsDaily).HasDefaultValueSql("0");

                entity.Property(e => e.EarnCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.OutputCode)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.OutputTable)
                    .IsRequired()
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.HasKey(e => e.RankCode)
                    .HasName("PK_Rank");

                entity.Property(e => e.RankCode).HasColumnType("char(1)");

                entity.Property(e => e.RankName).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Reason>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_Reason");

                entity.Property(e => e.Code).HasColumnType("char(5)");

                entity.Property(e => e.Descr).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Released>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK_Released");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.AppVersion)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.DbVersion)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ReleasedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.Script).HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.ReportCode)
                    .HasName("PK_Reports");

                entity.Property(e => e.ReportCode).HasColumnType("char(5)");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.CreateDiskClass).HasColumnType("varchar(30)");

                entity.Property(e => e.Crname)
                    .HasColumnName("CRName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Crname2)
                    .HasColumnName("CRName2")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Crtitle)
                    .HasColumnName("CRTitle")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DisketteForm)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DisketteFormType).HasColumnType("varchar(10)");

                entity.Property(e => e.ExportFileName).HasColumnType("varchar(50)");

                entity.Property(e => e.MainClass).HasColumnType("varchar(50)");

                entity.Property(e => e.MainSproc)
                    .HasColumnName("MainSProc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MainTableNames).HasColumnType("varchar(100)");

                entity.Property(e => e.Posted).HasDefaultValueSql("1");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ReportType).HasColumnType("char(1)");

                entity.Property(e => e.SubClass).HasColumnType("varchar(50)");

                entity.Property(e => e.SubSproc)
                    .HasColumnName("SubSProc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SubTableNames).HasColumnType("varchar(100)");

                entity.Property(e => e.WithDeductionFilter).HasDefaultValueSql("0");

                entity.Property(e => e.WithDeptFilter)
                    .HasColumnName("withDeptFilter")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WithEarningFilter).HasDefaultValueSql("0");

                entity.Property(e => e.WithEmployeeFilter)
                    .HasColumnName("withEmployeeFilter")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WithGrouping).HasDefaultValueSql("1");

                entity.Property(e => e.WithLoanFilter).HasDefaultValueSql("0");

                entity.Property(e => e.WithPaycodeFilter)
                    .HasColumnName("withPaycodeFilter")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WithSorting).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<SavedQuery>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.Title })
                    .HasName("IX_SavedQuery")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Header).HasColumnType("varchar(500)");

                entity.Property(e => e.Sql)
                    .HasColumnName("SQL")
                    .HasColumnType("varchar(4000)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(500)");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.SectCode })
                    .HasName("PK_Section");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.SectCode).HasColumnType("char(15)");

                entity.Property(e => e.DeptCode).HasColumnType("char(15)");

                entity.Property(e => e.SectDescr).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastSystemDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Signatories>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.SignatoryType, e.SignatoryName })
                    .HasName("PK_Signatories");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.SignatoryType).HasColumnType("char(15)");

                entity.Property(e => e.SignatoryName).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsApprover).HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SignatoryHeader).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Ssstable>(entity =>
            {
                entity.ToTable("SSSTable");

                entity.HasIndex(e => e.LowerLimit)
                    .HasName("IX_SSSTable")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeSss)
                    .HasColumnName("EmployeeSSS")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerEcc)
                    .HasColumnName("EmployerECC")
                    .HasColumnType("decimal");

                entity.Property(e => e.EmployerSss)
                    .HasColumnName("EmployerSSS")
                    .HasColumnType("decimal");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LowerLimit).HasColumnType("decimal");

                entity.Property(e => e.Total).HasColumnType("decimal");

                entity.Property(e => e.UpperLimit).HasColumnType("decimal");
            });

            modelBuilder.Entity<StaxTable>(entity =>
            {
                entity.HasKey(e => e.Exemption)
                    .HasName("PK_STaxTable");

                entity.ToTable("STaxTable");

                entity.Property(e => e.Exemption).HasColumnType("char(4)");

                entity.Property(e => e.Amount1).HasColumnType("decimal");

                entity.Property(e => e.Amount2).HasColumnType("decimal");

                entity.Property(e => e.Amount3).HasColumnType("decimal");

                entity.Property(e => e.Amount4).HasColumnType("decimal");

                entity.Property(e => e.Amount5).HasColumnType("decimal");

                entity.Property(e => e.Amount6).HasColumnType("decimal");

                entity.Property(e => e.Amount7).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TaxMethodByType>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ProcessType, e.PayCode })
                    .HasName("PK_TaxMethodByType");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.ProcessType).HasColumnType("varchar(20)");

                entity.Property(e => e.PayCode).HasColumnType("char(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("datetime");

                entity.Property(e => e.TaxMethod)
                    .IsRequired()
                    .HasColumnType("char(6)");
            });

            modelBuilder.Entity<Teu>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_TEU");

                entity.ToTable("TEU");

                entity.Property(e => e.Code).HasColumnType("char(4)");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId })
                    .HasName("PK_Timesheet");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Absences).HasColumnType("decimal");

                entity.Property(e => e.AbsentHours).HasColumnType("decimal");

                entity.Property(e => e.BackPaySldays)
                    .HasColumnName("BackPaySLdays")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPaySlhours)
                    .HasColumnName("BackPaySLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPayVldays)
                    .HasColumnName("BackPayVLdays")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPayVlhours)
                    .HasColumnName("BackPayVLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.CostCenter).HasColumnType("char(15)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Frequency).HasColumnType("varchar(20)");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Nd1regHours)
                    .HasColumnName("ND1RegHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Nd2regHours)
                    .HasColumnName("ND2RegHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.PaidHoliHours).HasColumnType("decimal");

                entity.Property(e => e.PaidHolidays).HasColumnType("decimal");

                entity.Property(e => e.RegDays).HasColumnType("decimal");

                entity.Property(e => e.RegHours).HasColumnType("decimal");

                entity.Property(e => e.Sldays)
                    .HasColumnName("SLDays")
                    .HasColumnType("decimal");

                entity.Property(e => e.Slhours)
                    .HasColumnName("SLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.TardyHours).HasColumnType("decimal");

                entity.Property(e => e.Uthours)
                    .HasColumnName("UTHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Vldays)
                    .HasColumnName("VLDays")
                    .HasColumnType("decimal");

                entity.Property(e => e.Vlhours)
                    .HasColumnName("VLHours")
                    .HasColumnType("decimal");
            });

            modelBuilder.Entity<Timesheet2>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.TsCode })
                    .HasName("PK_Timesheet2");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.TsCode)
                    .HasColumnName("TS_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TsDays)
                    .HasColumnName("TS_days")
                    .HasColumnType("decimal");

                entity.Property(e => e.TsHrs)
                    .HasColumnName("TS_hrs")
                    .HasColumnType("decimal");

                entity.Property(e => e.TsMins).HasColumnName("TS_mins");

                entity.HasOne(d => d.Timesheet2Code)
                    .WithMany(p => p.Timesheet2)
                    .HasForeignKey(d => new { d.CompanyId, d.TsCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Timesheet2_Timesheet2Code");
            });

            modelBuilder.Entity<Timesheet2Code>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.TsCode })
                    .HasName("PK_Timesheet2Code");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TsCode)
                    .HasColumnName("TS_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.AcctCode).HasColumnType("varchar(20)");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.HasDayInput)
                    .HasColumnName("hasDayInput")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Multiplier).HasDefaultValueSql("1");

                entity.Property(e => e.Taxable).HasDefaultValueSql("1");

                entity.Property(e => e.TsDescr)
                    .IsRequired()
                    .HasColumnName("TS_descr")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TsName)
                    .IsRequired()
                    .HasColumnName("TS_name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TsType)
                    .HasColumnName("TS_Type")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Timesheet2Staging>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.Id })
                    .HasName("PK_Timesheet2_Staging");

                entity.ToTable("Timesheet2_Staging");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.TsCode)
                    .IsRequired()
                    .HasColumnName("TS_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TsDays)
                    .HasColumnName("TS_days")
                    .HasColumnType("decimal");

                entity.Property(e => e.TsHrs)
                    .HasColumnName("TS_hrs")
                    .HasColumnType("decimal");

                entity.Property(e => e.TsMins).HasColumnName("TS_mins");
            });

            modelBuilder.Entity<TimesheetMapping>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.TranId, e.TsColumn })
                    .HasName("PK_TimesheetMapping");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TranId)
                    .HasColumnName("TranID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TsColumn)
                    .HasColumnName("TS_Column")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AcctCode).HasColumnType("char(15)");

                entity.Property(e => e.Description).HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<TimesheetStaging>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.Id })
                    .HasName("PK_Timesheet_Staging");

                entity.ToTable("Timesheet_Staging");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Absences).HasColumnType("decimal");

                entity.Property(e => e.AbsentHours).HasColumnType("decimal");

                entity.Property(e => e.BackPaySldays)
                    .HasColumnName("BackPaySLdays")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPaySlhours)
                    .HasColumnName("BackPaySLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPayVldays)
                    .HasColumnName("BackPayVLdays")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPayVlhours)
                    .HasColumnName("BackPayVLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Nd1regHours)
                    .HasColumnName("ND1RegHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Nd2regHours)
                    .HasColumnName("ND2RegHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.PaidHoliHours).HasColumnType("decimal");

                entity.Property(e => e.PaidHolidays).HasColumnType("decimal");

                entity.Property(e => e.RegDays).HasColumnType("decimal");

                entity.Property(e => e.RegHours).HasColumnType("decimal");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Sldays)
                    .HasColumnName("SLDays")
                    .HasColumnType("decimal");

                entity.Property(e => e.Slhours)
                    .HasColumnName("SLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.TardyHours).HasColumnType("decimal");

                entity.Property(e => e.Uthours)
                    .HasColumnName("UTHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Vldays)
                    .HasColumnName("VLDays")
                    .HasColumnType("decimal");

                entity.Property(e => e.Vlhours)
                    .HasColumnName("VLHours")
                    .HasColumnType("decimal");
            });

            modelBuilder.Entity<TimesheetTmp>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId })
                    .HasName("PK_TimesheetTmp");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.AbsenceAmt).HasColumnType("decimal");

                entity.Property(e => e.Absences).HasColumnType("decimal");

                entity.Property(e => e.AbsentHours).HasColumnType("decimal");

                entity.Property(e => e.BackPaySlamt)
                    .HasColumnName("BackPaySLAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPaySldays)
                    .HasColumnName("BackPaySLdays")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPaySlhours)
                    .HasColumnName("BackPaySLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPayVlamt)
                    .HasColumnName("BackPayVLAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPayVldays)
                    .HasColumnName("BackPayVLdays")
                    .HasColumnType("decimal");

                entity.Property(e => e.BackPayVlhours)
                    .HasColumnName("BackPayVLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.CostCenter).HasColumnType("char(15)");

                entity.Property(e => e.Nd1regAmt)
                    .HasColumnName("ND1RegAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Nd1regHours)
                    .HasColumnName("ND1RegHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Nd2regAmt)
                    .HasColumnName("ND2RegAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Nd2regHours)
                    .HasColumnName("ND2RegHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.PaidHoliAmt).HasColumnType("decimal");

                entity.Property(e => e.PaidHoliHours).HasColumnType("decimal");

                entity.Property(e => e.PaidHolidays).HasColumnType("decimal");

                entity.Property(e => e.RegAmt).HasColumnType("decimal");

                entity.Property(e => e.RegDays).HasColumnType("decimal");

                entity.Property(e => e.RegHours).HasColumnType("decimal");

                entity.Property(e => e.Slamt)
                    .HasColumnName("SLAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Sldays)
                    .HasColumnName("SLDays")
                    .HasColumnType("decimal");

                entity.Property(e => e.Slhours)
                    .HasColumnName("SLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.TardyAmt).HasColumnType("decimal");

                entity.Property(e => e.TardyHours).HasColumnType("decimal");

                entity.Property(e => e.Utamt)
                    .HasColumnName("UTAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Uthours)
                    .HasColumnName("UTHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.Vlamt)
                    .HasColumnName("VLAmt")
                    .HasColumnType("decimal");

                entity.Property(e => e.Vldays)
                    .HasColumnName("VLDays")
                    .HasColumnType("decimal");

                entity.Property(e => e.Vlhours)
                    .HasColumnName("VLHours")
                    .HasColumnType("decimal");

                entity.Property(e => e.XxxpaidHolidays).HasColumnName("XXXPaidHolidays");
            });

            modelBuilder.Entity<TimesheetTmp2>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.TsCode })
                    .HasName("PK_TimesheetTmp2");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("char(15)");

                entity.Property(e => e.TsCode)
                    .HasColumnName("TS_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.TsAmt)
                    .HasColumnName("TS_amt")
                    .HasColumnType("decimal");

                entity.Property(e => e.TsDays)
                    .HasColumnName("TS_days")
                    .HasColumnType("decimal");

                entity.Property(e => e.TsHrs)
                    .HasColumnName("TS_hrs")
                    .HasColumnType("decimal");

                entity.Property(e => e.TsMins).HasColumnName("TS_mins");
            });

            modelBuilder.Entity<UserAssDtl>(entity =>
            {
                entity.HasKey(e => new { e.UserAssId, e.Paycode })
                    .HasName("PK_UserAssDtl");

                entity.Property(e => e.UserAssId).HasColumnName("UserAssID");

                entity.Property(e => e.Paycode).HasColumnType("char(10)");
            });

            modelBuilder.Entity<UserAssign>(entity =>
            {
                entity.HasKey(e => e.UserAssId)
                    .HasName("PK_UserAssign");

                entity.HasIndex(e => new { e.CompanyId, e.UserId })
                    .HasName("IX_UserAssign")
                    .IsUnique();

                entity.Property(e => e.UserAssId).HasColumnName("UserAssID");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.PaycodeAccess)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasColumnType("char(10)");
            });

            modelBuilder.Entity<UserReports>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReportCode)
                    .IsRequired()
                    .HasColumnType("char(5)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("char(15)");
            });

            modelBuilder.Entity<WtaxTable>(entity =>
            {
                entity.HasKey(e => e.Exemption)
                    .HasName("PK_WTaxTable");

                entity.ToTable("WTaxTable");

                entity.Property(e => e.Exemption).HasColumnType("char(10)");

                entity.Property(e => e.Amount1).HasColumnType("decimal");

                entity.Property(e => e.Amount2).HasColumnType("decimal");

                entity.Property(e => e.Amount3).HasColumnType("decimal");

                entity.Property(e => e.Amount4).HasColumnType("decimal");

                entity.Property(e => e.Amount5).HasColumnType("decimal");

                entity.Property(e => e.Amount6).HasColumnType("decimal");

                entity.Property(e => e.Amount7).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YtaxTable>(entity =>
            {
                entity.ToTable("YTaxTable");

                entity.HasIndex(e => e.Llimit)
                    .HasName("IX_YTaxTable")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Fa)
                    .HasColumnName("FA")
                    .HasColumnType("decimal");

                entity.Property(e => e.LastUpdBy)
                    .IsRequired()
                    .HasColumnType("char(15)");

                entity.Property(e => e.LastUpdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Llimit)
                    .HasColumnName("LLIMIT")
                    .HasColumnType("decimal");

                entity.Property(e => e.Pct)
                    .HasColumnName("PCT")
                    .HasColumnType("decimal");

                entity.Property(e => e.Ulimit)
                    .HasColumnName("ULIMIT")
                    .HasColumnType("decimal");
            });
        }
    }
}