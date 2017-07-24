using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Payroll.Models;

namespace Payroll.Data
{
    public partial class APPSECUContext : DbContext
    {
        public virtual DbSet<FieldAccess> FieldAccess { get; set; }
        public virtual DbSet<Fields> Fields { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<RoleModule> RoleModule { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-JUSM0M5\SQLEXPRESS;Database=APPSECU_DEV2;Trusted_Connection=True;");
        //}

        public APPSECUContext(DbContextOptions<APPSECUContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FieldAccess>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Fields>(entity =>
            {
                entity.HasKey(e => e.FieldId)
                    .HasName("PK_Fields");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasKey(e => new { e.Application, e.ModuleId })
                    .HasName("PK_Modules");

                entity.Property(e => e.Application).HasColumnType("char(10)");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasColumnType("varchar(100)");

                entity.Property(e => e.Hierarchy)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ModuleCode).HasColumnType("char(10)");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("varchar(40)");
            });

            modelBuilder.Entity<RoleModule>(entity =>
            {
                entity.HasKey(e => new { e.Application, e.RoleModId })
                    .HasName("PK_RoleModule");

                entity.Property(e => e.Application).HasColumnType("char(10)");

                entity.Property(e => e.RoleModId)
                    .HasColumnName("RoleModID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => new { e.Application, e.RoleId })
                    .HasName("PK_Roles");

                entity.Property(e => e.Application).HasColumnType("char(10)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasColumnType("varchar(40)");

                entity.Property(e => e.ShortDesc).HasColumnType("varchar(15)");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.Application, e.UserRoleId })
                    .HasName("PK_UserRole");

                entity.Property(e => e.Application).HasColumnType("char(10)");

                entity.Property(e => e.UserRoleId)
                    .HasColumnName("UserRoleID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasColumnType("char(10)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => new { e.Application, e.UserId })
                    .HasName("PK_Users");

                entity.Property(e => e.Application).HasColumnType("char(10)");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Activated).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.UserFname)
                    .IsRequired()
                    .HasColumnName("UserFName")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.UserLname)
                    .IsRequired()
                    .HasColumnName("UserLName")
                    .HasColumnType("varchar(25)");
            });
        }
    }
}