﻿// <auto-generated />
using System;
using JimazonLite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JimazonLite.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230708005320_validations added")]
    partial class validationsadded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("JimazonLite.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModelNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Donner Electric Guitar",
                            ImageUrl = "",
                            ModelNumber = "DT400",
                            Name = "Electric Guitar",
                            Price = 125f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Yamaha Studio Speaker",
                            ImageUrl = "",
                            ModelNumber = "HS7",
                            Name = "Studio Speaker",
                            Price = 150f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            DateAdded = new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Folding Camping Cot",
                            ImageUrl = "",
                            ModelNumber = "",
                            Name = "Camping Cot",
                            Price = 50f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 4,
                            DateAdded = new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Koda Retrospec Bicycle",
                            ImageUrl = "",
                            ModelNumber = "",
                            Name = "Bicycle",
                            Price = 40f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 5,
                            DateAdded = new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "GreenWorks 24V Hedge Trimmer",
                            ImageUrl = "",
                            ModelNumber = "",
                            Name = "Hedge Trimmer",
                            Price = 35f,
                            Quantity = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
