using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVC_BikeStores.Models
{
    public partial class BikeStoresContext : DbContext
    {
        public BikeStoresContext()
            : base("name=BikeStoresContext")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order_Items> Order_Items { get; set; }
        public virtual DbSet<Order_Status> Order_Status { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.Brand_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Category_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.List_Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Zip_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer)
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

            modelBuilder.Entity<Staff>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Staffs1)
                .WithOptional(e => e.Staff1)
                .HasForeignKey(e => e.Manager_Id);

            modelBuilder.Entity<Store>()
                .Property(e => e.Store_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Zip_Code)
                .IsUnicode(false);
        }
    }
}
