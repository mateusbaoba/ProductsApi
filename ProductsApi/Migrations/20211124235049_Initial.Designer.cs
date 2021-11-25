﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsApi.Models;

#nullable disable

namespace ProductsApi.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20211124235049_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProductsApi.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductsApi.Models.ProductionOrder", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("QuantityProduced")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("QuantityRequired")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductionOrder");
                });

            modelBuilder.Entity("ProductsApi.Models.ProductionOrder", b =>
                {
                    b.HasOne("ProductsApi.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
