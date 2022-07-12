using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVC_BikeStore.Models
{
    public partial class BikeStoresContext : DbContext
    {
        public BikeStoresContext()
            : base("name=BikeStoresContext")
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Stocks> Stocks { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Order_Items> Order_Items { get; set; }
        public virtual DbSet<Order_Status> Order_Status { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Staffs> Staffs { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>()
                .Property(e => e.Brand_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .Property(e => e.Category_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Product_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.List_Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customers>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Zip_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customers)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Order_Items>()
                .Property(e => e.List_Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order_Items>()
                .Property(e => e.Discount)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Order_Status>()
                .Property(e => e.Status_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Order_Status>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Order_Status)
                .HasForeignKey(e => e.Order_Status_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staffs>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Staffs>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Staffs>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Staffs>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Staffs>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Staffs)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staffs>()
                .HasMany(e => e.Staffs1)
                .WithOptional(e => e.Staffs2)
                .HasForeignKey(e => e.Manager_Id);

            modelBuilder.Entity<Stores>()
                .Property(e => e.Store_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Stores>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Stores>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Stores>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Stores>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Stores>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Stores>()
                .Property(e => e.Zip_Code)
                .IsUnicode(false);
        }
    }
}
