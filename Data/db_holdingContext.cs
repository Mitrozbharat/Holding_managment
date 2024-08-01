using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Holding_managment.Data
{
    public partial class db_holdingContext : DbContext
    {
       
        public db_holdingContext(DbContextOptions<db_holdingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCampaign> TblCampaigns { get; set; } = null!;
        public virtual DbSet<TblCustomer> TblCustomers { get; set; } = null!;
        public virtual DbSet<TblInventory> TblInventories { get; set; } = null!;
        public virtual DbSet<TblQuotation> TblQuotations { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;
        public virtual DbSet<TblVendor> TblVendors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<TblCampaign>(entity =>
            {
                entity.ToTable("tbl_campaign");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BookingAmt).HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FkCutomerId).HasColumnName("Fk_CutomerId");

                entity.Property(e => e.FkInventoryId).HasColumnName("Fk_inventoryId");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasColumnType("bit(1)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.ToTable("tbl_customer");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.BusinessName).HasMaxLength(255);

                entity.Property(e => e.ContactNo).HasMaxLength(255);

                entity.Property(e => e.ContactNo2).HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GstNo).HasMaxLength(255);

                entity.Property(e => e.IsDelete).HasColumnType("bit(1)");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            });

            modelBuilder.Entity<TblInventory>(entity =>
            {
                entity.ToTable("tbl_inventory");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area).HasMaxLength(255);

                entity.Property(e => e.BookingStatus).HasColumnType("bit(1)");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FkVendorId).HasColumnName("Fk_vendorId");

                entity.Property(e => e.Height).HasMaxLength(255);

                entity.Property(e => e.Image).HasMaxLength(255);

                entity.Property(e => e.IsLight).HasColumnType("bit(1)");

                entity.Property(e => e.Isdelete).HasColumnType("bit(1)");

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.Rate).HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.VendorAmt).HasMaxLength(255);

                entity.Property(e => e.Width).HasMaxLength(255);
            });

            modelBuilder.Entity<TblQuotation>(entity =>
            {
                entity.ToTable("tbl_quotation");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area).HasMaxLength(255);

                entity.Property(e => e.BookingStatus).HasColumnType("bit(1)");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FkCustomerId).HasColumnName("Fk_CustomerId");

                entity.Property(e => e.FkVendorId).HasColumnName("Fk_vendorId");

                entity.Property(e => e.Height).HasMaxLength(255);

                entity.Property(e => e.Image).HasMaxLength(255);

                entity.Property(e => e.IsDelete).HasColumnType("bit(1)");

                entity.Property(e => e.IsLight).HasColumnType("bit(1)");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.LocationDescription).HasMaxLength(255);

                entity.Property(e => e.MarginAmt).HasMaxLength(255);

                entity.Property(e => e.QuotationNumber).HasMaxLength(255);

                entity.Property(e => e.Rate).HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.VendorAmt).HasMaxLength(255);

                entity.Property(e => e.Width).HasMaxLength(255);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_user");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IsDelete)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<TblVendor>(entity =>
            {
                entity.ToTable("tbl_vendor");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.BusinessName).HasMaxLength(255);

                entity.Property(e => e.ConatactNo2).HasMaxLength(255);

                entity.Property(e => e.ContactNo).HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GstNo).HasMaxLength(255);

                entity.Property(e => e.Isdelete).HasColumnType("bit(1)");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.VendorNmae).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
