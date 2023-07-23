using JimazonLite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimazonLite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public string DbPath { get; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> db) : base(db)
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "JimazonLite.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite($"Data Source={DbPath}");
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Scottie\source\repos\JimazonLite\DbStorage\JimazonLite.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Electric Guitar", Description = "Donner Electric Guitar", ModelNumber = "DT400", Price = 130.00f, ImageUrl = @"\images\product\cda4d0fe-32d4-479e-bc08-1c07ec5215ee.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 5},
                new Product { Id = 2, Name = "Studio Speaker", Description = "Yamaha Studio Speaker", ModelNumber = "HS7", Price = 150.00f, ImageUrl = @"\images\product\f9f20438-8fdd-4ad6-ba13-3f51b7274e32.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 },
                new Product { Id = 3, Name = "ASUS ROG RTX 3080Ti", Description = "Asus Republic of Gamers Nvidia RTX 3080Ti 12GB", ModelNumber = "", Price = 800f, ImageUrl = @"\images\product\2852c5e5-50c0-4723-bafa-c3c5f4e49690.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 },
                new Product { Id = 4, Name = "Bicycle", Description = "Koda Retrospec Bicycle", ModelNumber = "KODA14A", Price = 40.00f, ImageUrl = @"\images\product\0d4d8414-c74c-45ca-9483-7057638939f9.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 3 },
                new Product { Id = 5, Name = "Hedge Trimmer", Description = "GreenWorks 24V Hedge Trimmer", ModelNumber = "GRNW9687", Price = 35.00f, ImageUrl = @"\images\product\d2ab5aaa-9684-4cc5-8d6a-a3536c11a405.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 4 },
                new Product { Id = 6, Name = "Flight Stick", Description = "Thrustmaster T-Hotas Flight Stick for Xbox/PX", ModelNumber = "THR5521", Price = 90.00f,ImageUrl = @"\images\product\31576b7c-a633-4d74-9fd5-2aded0e2fdd7.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 },
                new Product { Id = 7, Name = "Xbox Series X", Description = "Xbox Series X 1TB Video Game Console", ModelNumber = "MCSFTXBX901A", Price = 400.00f, ImageUrl = @"\images\product\fcec7f75-8d7e-4b95-aeb8-8e3b6f3b8754.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 },
                new Product { Id = 8, Name = "MSI RTX 4090", Description = "MSI Gaming Trio Nvidia RTX 4900 24BG", ModelNumber = "MSI4090", Price = 1350.00f ,ImageUrl = @"\images\product\dff28cfc-48f8-43a1-9db1-c785afb631cd.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics"},
                new Category { Id = 2, Name = "Appliances"},
                new Category { Id = 3, Name = "Sporting Goods and Outdoors"},
                new Category { Id = 4, Name = "Lawn and Garden"},
                new Category { Id = 5, Name = "Musical Instruments"},
                new Category { Id = 6, Name = "Furniture"}
                );
        }
    }
}