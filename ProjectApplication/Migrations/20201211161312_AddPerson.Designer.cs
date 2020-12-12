﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectApplication.Data;

namespace ProjectApplication.Migrations
{
    [DbContext(typeof(appDBcontent))]
    [Migration("20201211161312_AddPerson")]
    partial class AddPerson
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjectApplication.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("categoryName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("desc")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.MilkProd", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("available")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<string>("fatMass")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("img")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("isFavourite")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("mass")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<ushort>("price")
                        .HasColumnType("smallint unsigned");

                    b.Property<string>("storageDate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("temperature")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("MilkProds");
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime>("oredertime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("varchar(12) CHARACTER SET utf8mb4")
                        .HasMaxLength(12);

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<uint>("price")
                        .HasColumnType("int unsigned");

                    b.HasKey("id");

                    b.HasIndex("CarId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.ShopFav", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ShopCartid")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("carid")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("carid");

                    b.ToTable("ShopFav");
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.UserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.MilkProd", b =>
                {
                    b.HasOne("ProjectApplication.Data.Models.Category", "Category")
                        .WithMany("cars")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("ProjectApplication.Data.Models.MilkProd", "car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectApplication.Data.Models.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.ShopFav", b =>
                {
                    b.HasOne("ProjectApplication.Data.Models.MilkProd", "car")
                        .WithMany()
                        .HasForeignKey("carid");
                });

            modelBuilder.Entity("ProjectApplication.Data.Models.UserModel", b =>
                {
                    b.HasOne("ProjectApplication.Data.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
