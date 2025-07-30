using Management.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Management.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<EmployeeMaster> Employees { get; set; }
        public DbSet<AssetMaster> Assets { get; set; }
        public DbSet<SupplierMaster> Suppliers { get; set; }
        public DbSet<EmployeeAsset> EmployeeAssets { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships

            modelBuilder.Entity<EmployeeAsset>()
                .HasOne(ea => ea.Employee)
                .WithMany()
                .HasForeignKey(ea => ea.AssetId)
                .IsRequired(false);

            modelBuilder.Entity<EmployeeAsset>()
                .HasOne(ea => ea.Asset)
                .WithMany()
                .HasForeignKey(ea => ea.AssetId)
                .IsRequired(false);
        }
    }
}