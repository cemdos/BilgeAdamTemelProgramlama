using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Porto.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.DAL.EntityFramework
{
    public class PortoDbContext:DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.ID_Category)
                .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.SubCategories)
                .WithOne(e => e.SubCategory)
                .HasForeignKey(e => e.ParentID)
                .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Pictures)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ID_Product)
                .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.InvoiceDetailList)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ID_Product)
                .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDetailList)
                .WithOne(e => e.Invoice)
                .HasForeignKey(e => e.ID_Invoice)
                .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.InvoiceList)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .HasPrincipalKey(e => e.ID);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string sqlConn = "Server=DESKTOP-FH3V2M3\\SQLEXPRESS;Initial Catalog = PortoDb;Integrated Security=True;TrustServerCertificate=True";

            //ConfigurationBuilder configurationBuilder = new();
            //IConfigurationRoot configurationRoot = configurationBuilder.Build();
            //string sqlConn = configurationRoot.GetSection("SqlConn").Value;

            optionsBuilder.UseSqlServer(sqlConn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
