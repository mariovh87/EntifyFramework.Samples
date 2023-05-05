﻿// <auto-generated />
using System;
using EntityFramework.Samples.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFramework.Samples.Data.Migrations
{
    [DbContext(typeof(ContosoPizzaContext))]
    [Migration("20230426141501_AddSeed")]
    partial class AddSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFramework.Samples.Data.Models.ContosoPizza.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "1234 Main St",
                            FirstName = "Carson",
                            LastName = "Alexander",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "1234 Main St",
                            FirstName = "Meredith",
                            LastName = "Alonso",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "1234 Main St",
                            FirstName = "Arturo",
                            LastName = "Anand",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "1234 Main St",
                            FirstName = "Gytis",
                            LastName = "Barzdukas",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            CustomerId = 5,
                            Address = "1234 Main St",
                            FirstName = "Yan",
                            LastName = "Li",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            CustomerId = 6,
                            Address = "1234 Main St",
                            FirstName = "Peggy",
                            LastName = "Justice",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            CustomerId = 7,
                            Address = "1234 Main St",
                            FirstName = "Laura",
                            LastName = "Norman",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            CustomerId = 8,
                            Address = "1234 Main St",
                            FirstName = "Nino",
                            LastName = "Olivetto",
                            Phone = "555-555-5555"
                        });
                });

            modelBuilder.Entity("EntityFramework.Samples.Data.Models.ContosoPizza.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderFulfilled")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EntityFramework.Samples.Data.Models.ContosoPizza.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("EntityFramework.Samples.Data.Models.ContosoPizza.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Name = "Pizza Margherita",
                            Price = 10.00m
                        },
                        new
                        {
                            ProductId = 2,
                            Name = "Pizza Marinara",
                            Price = 10.00m
                        },
                        new
                        {
                            ProductId = 3,
                            Name = "Pizza Quattro Stagioni",
                            Price = 10.00m
                        },
                        new
                        {
                            ProductId = 4,
                            Name = "Pizza Quattro Formaggi",
                            Price = 10.00m
                        },
                        new
                        {
                            ProductId = 5,
                            Name = "Pizza Capricciosa",
                            Price = 10.00m
                        },
                        new
                        {
                            ProductId = 6,
                            Name = "Pizza Funghi",
                            Price = 12.00m
                        },
                        new
                        {
                            ProductId = 7,
                            Name = "Pizza Prosciutto",
                            Price = 12.00m
                        });
                });

            modelBuilder.Entity("EntityFramework.Samples.Data.Models.ContosoPizza.Order", b =>
                {
                    b.HasOne("EntityFramework.Samples.Data.Models.ContosoPizza.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("EntityFramework.Samples.Data.Models.ContosoPizza.OrderDetail", b =>
                {
                    b.HasOne("EntityFramework.Samples.Data.Models.ContosoPizza.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework.Samples.Data.Models.ContosoPizza.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityFramework.Samples.Data.Models.ContosoPizza.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("EntityFramework.Samples.Data.Models.ContosoPizza.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}