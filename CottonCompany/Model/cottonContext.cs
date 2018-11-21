using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CottonCompany.Model
{
    public partial class CottonContext : DbContext
    {
        public CottonContext()
        {
        }

        public CottonContext(DbContextOptions<CottonContext> options)
            : base(options)
        {
        }


        

        public virtual DbSet<NDelivery> NDelivery { get; set; }
        public virtual DbSet<NFilter> NFilter { get; set; }
        public virtual DbSet<NLocation> NLocation { get; set; }
        public virtual DbSet<NPerson> NPerson { get; set; }
        public virtual DbSet<NProduct> NProduct { get; set; }
        public virtual DbSet<NRegion> NRegion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=cotton;Username=postgres;Password=postgres");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NDelivery>(entity =>
            {
                entity.HasKey(e => e.Deliveryid);

                entity.ToTable("n_delivery");

                entity.Property(e => e.Deliveryid).HasColumnName("deliveryid");

                entity.Property(e => e.Deliverydate).HasColumnName("deliverydate");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<NFilter>(entity =>
            {
                entity.HasKey(e => e.Filterid);

                entity.ToTable("n_filter");

                entity.Property(e => e.Filterid).HasColumnName("filterid");

                entity.Property(e => e.Filtername)
                    .IsRequired()
                    .HasColumnName("filtername")
                    .HasColumnType("character varying");

                entity.Property(e => e.Filtertype)
                    .IsRequired()
                    .HasColumnName("filtertype")
                    .HasColumnType("character varying");

                entity.Property(e => e.LinkedfieldGetvalue)
                    .HasColumnName("linkedfield_getvalue")
                    .HasColumnType("character varying");

                entity.Property(e => e.LinkedfieldToshow)
                    .HasColumnName("linkedfield_toshow")
                    .HasColumnType("character varying");

                entity.Property(e => e.Linkedtable)
                    .HasColumnName("linkedtable")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sequence).HasColumnName("sequence");
            });

            modelBuilder.Entity<NLocation>(entity =>
            {
                entity.HasKey(e => e.Locationid);

                entity.ToTable("n_location");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(128);

                entity.Property(e => e.Regionid).HasColumnName("regionid");
            });

            modelBuilder.Entity<NPerson>(entity =>
            {
                entity.HasKey(e => e.Personid);

                entity.ToTable("n_person");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.Personname)
                    .IsRequired()
                    .HasColumnName("personname")
                    .HasMaxLength(128);

                entity.Property(e => e.Regionid).HasColumnName("regionid");
            });

            modelBuilder.Entity<NProduct>(entity =>
            {
                entity.HasKey(e => e.Productid);

                entity.ToTable("n_product");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Productname)
                    .IsRequired()
                    .HasColumnName("productname")
                    .HasMaxLength(128);

                entity.Property(e => e.WeightPerItem)
                    .HasColumnName("weight_per_item")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<NRegion>(entity =>
            {
                entity.HasKey(e => e.Regionid);

                entity.ToTable("n_region");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Regionname)
                    .IsRequired()
                    .HasColumnName("regionname")
                    .HasMaxLength(128);
            });
        }
    }
}
