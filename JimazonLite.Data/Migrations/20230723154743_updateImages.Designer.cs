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
    [Migration("20230723154743_updateImages")]
    partial class updateImages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("JimazonLite.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Appliances"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sporting Goods and Outdoors"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lawn and Garden"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Musical Instruments"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Furniture"
                        });
                });

            modelBuilder.Entity("JimazonLite.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModelNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 5,
                            DateAdded = new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Donner Electric Guitar",
                            ImageUrl = "images\\product\\cda4d0fe-32d4-479e-bc08-1c07ec5215ee.jpg",
                            ModelNumber = "DT400",
                            Name = "Electric Guitar",
                            Price = 130f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateAdded = new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Yamaha Studio Speaker",
                            ImageUrl = "images\\product\\f9f20438-8fdd-4ad6-ba13-3f51b7274e32.jpg",
                            ModelNumber = "HS7",
                            Name = "Studio Speaker",
                            Price = 150f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateAdded = new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Asus Republic of Gamers Nvidia RTX 3080Ti 12GB",
                            ImageUrl = "images\\product\\2852c5e5-50c0-4723-bafa-c3c5f4e49690.jpg",
                            ModelNumber = "",
                            Name = "ASUS ROG RTX 3080Ti",
                            Price = 800f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            DateAdded = new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Koda Retrospec Bicycle",
                            ImageUrl = "images\\product\\0d4d8414-c74c-45ca-9483-7057638939f9.jpg",
                            ModelNumber = "KODA14A",
                            Name = "Bicycle",
                            Price = 40f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            DateAdded = new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "GreenWorks 24V Hedge Trimmer",
                            ImageUrl = "images\\product\\d2ab5aaa-9684-4cc5-8d6a-a3536c11a405.jpg",
                            ModelNumber = "GRNW9687",
                            Name = "Hedge Trimmer",
                            Price = 35f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            DateAdded = new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Thrustmaster T-Hotas Flight Stick for Xbox/PX",
                            ImageUrl = "images\\product\\31576b7c-a633-4d74-9fd5-2aded0e2fdd7.jpg",
                            ModelNumber = "THR5521",
                            Name = "Flight Stick",
                            Price = 90f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            DateAdded = new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Xbox Series X 1TB Video Game Console",
                            ImageUrl = "images\\product\\fcec7f75-8d7e-4b95-aeb8-8e3b6f3b8754.jpg",
                            ModelNumber = "MCSFTXBX901A",
                            Name = "Xbox Series X",
                            Price = 400f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            DateAdded = new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "MSI Gaming Trio Nvidia RTX 4900 24BG",
                            ImageUrl = "images\\product\\dff28cfc-48f8-43a1-9db1-c785afb631cd.jpg",
                            ModelNumber = "MSI4090",
                            Name = "MSI RTX 4090",
                            Price = 1350f,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("JimazonLite.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("JimazonLite.Models.Product", b =>
                {
                    b.HasOne("JimazonLite.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}