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
