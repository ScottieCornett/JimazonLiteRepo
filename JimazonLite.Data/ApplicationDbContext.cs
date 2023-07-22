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
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "JimazonLite.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Electric Guitar", Description = "Donner Electric Guitar", ModelNumber = "DT400", Price = 125.00f, ImageUrl = @"images\product\acab30e9-3a78-4483-ac1a-257649072f17.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 5},
                new Product { Id = 2, Name = "Studio Speaker", Description = "Yamaha Studio Speaker", ModelNumber = "HS7", Price = 150.00f, ImageUrl = @"images\product\a72415bc-2812-42e6-94a2-98da457c01fa.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 },
                new Product { Id = 3, Name = "ASUS ROG RTX 3080Ti", Description = "Asus Republic of Gamers Nvidia RTX 3080Ti 12GB", ModelNumber = "", Price = 800f, ImageUrl = @"images\product\7e11a6a3-805a-471f-a0c9-a7d1dd6d0db7.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 },
                new Product { Id = 4, Name = "Bicycle", Description = "Koda Retrospec Bicycle", ModelNumber = "KODA14A", Price = 40.00f, ImageUrl = @"images\product\c459486b-f50a-4841-8f84-2a52914e6f74.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 3 },
                new Product { Id = 5, Name = "Hedge Trimmer", Description = "GreenWorks 24V Hedge Trimmer", ModelNumber = "GRNW9687", Price = 35.00f, ImageUrl = @"images\product\35f44e1d-e97a-4470-a9da-5c6931c64138.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 4 },
                new Product { Id = 6, Name = "Flight Stick", Description = "Thrustmaster T-Hotas Flight Stick for Xbox/PX", ModelNumber = "THR5521", Price = 90.00f,ImageUrl = @"images\product\2f6ebfc9-49f0-4e30-b28a-f3e3ef4d982b.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 },
                new Product { Id = 7, Name = "Xbox Series X", Description = "Xbox Series X 1TB Video Game Console", ModelNumber = "MCSFTXBX901A", Price = 400.00f, ImageUrl = @"images\product\3ce1528f-273e-440d-855f-e54ab679cb95.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 },
                new Product { Id = 8, Name = "MSI RTX 4090", Description = "MSI Gaming Trio Nvidia RTX 4900 24BG", ModelNumber = "MSI4090", Price = 1350.00f ,ImageUrl = @"images\product\d3ecb2fa-5216-4f55-b2a5-dce5feead3f0.jpg", DateAdded = DateTime.Today, Quantity = 1, CategoryId = 1 });

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