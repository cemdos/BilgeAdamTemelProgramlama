﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Porto.DAL.EntityFramework;

#nullable disable

namespace Porto.DAL.Migrations
{
    [DbContext(typeof(PortoDbContext))]
    partial class PortoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Porto.MODEL.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Porto.MODEL.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Porto.MODEL.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Porto.MODEL.InvoiceDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ID_Invoice")
                        .HasColumnType("int");

                    b.Property<int>("ID_Product")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ID_Invoice");

                    b.HasIndex("ID_Product");

                    b.ToTable("InvoiceDetail");
                });

            modelBuilder.Entity("Porto.MODEL.Picture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ID_Product")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ID_Product");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("Porto.MODEL.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<int?>("ID_Category")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnitPriceInStock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ID_Category");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Porto.MODEL.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Porto.MODEL.Category", b =>
                {
                    b.HasOne("Porto.MODEL.Category", "SubCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentID");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Porto.MODEL.Invoice", b =>
                {
                    b.HasOne("Porto.MODEL.Customer", "Customer")
                        .WithMany("InvoiceList")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Porto.MODEL.InvoiceDetail", b =>
                {
                    b.HasOne("Porto.MODEL.Invoice", "Invoice")
                        .WithMany("InvoiceDetailList")
                        .HasForeignKey("ID_Invoice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Porto.MODEL.Product", "Product")
                        .WithMany("InvoiceDetailList")
                        .HasForeignKey("ID_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Porto.MODEL.Picture", b =>
                {
                    b.HasOne("Porto.MODEL.Product", "Product")
                        .WithMany("Pictures")
                        .HasForeignKey("ID_Product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Porto.MODEL.Product", b =>
                {
                    b.HasOne("Porto.MODEL.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("ID_Category");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Porto.MODEL.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Porto.MODEL.Customer", b =>
                {
                    b.Navigation("InvoiceList");
                });

            modelBuilder.Entity("Porto.MODEL.Invoice", b =>
                {
                    b.Navigation("InvoiceDetailList");
                });

            modelBuilder.Entity("Porto.MODEL.Product", b =>
                {
                    b.Navigation("InvoiceDetailList");

                    b.Navigation("Pictures");
                });
#pragma warning restore 612, 618
        }
    }
}
