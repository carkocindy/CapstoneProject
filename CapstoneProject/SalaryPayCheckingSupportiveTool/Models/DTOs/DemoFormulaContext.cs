using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SalaryPayCheckingSupportiveTool.Models.DTOs
{
    public partial class DemoFormulaContext : DbContext
    {
        public DemoFormulaContext()
        {
        }

        public DemoFormulaContext(DbContextOptions<DemoFormulaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyAccount> CompanyAccount { get; set; }
        public virtual DbSet<Formula> Formula { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=DemoFormula;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CompanyAccount>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyAccount")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.HasOne(d => d.Company)
                    .WithOne(p => p.CompanyAccount)
                    .HasForeignKey<CompanyAccount>(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyAccount_Company");
            });

            modelBuilder.Entity<Formula>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyAccountId).HasColumnName("CompanyAccountID");

                entity.Property(e => e.FormulaName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormulaString).IsRequired();

                entity.HasOne(d => d.CompanyAccount)
                    .WithMany(p => p.Formula)
                    .HasForeignKey(d => d.CompanyAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Formula_CompanyAccount");
            });
        }
    }
}
