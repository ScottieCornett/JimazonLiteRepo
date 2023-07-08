using JimazonLite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimazonLite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
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
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Electric Guitar", Description = "Donner Electric Guitar", ModelNumber = "DT400", Price = 125.00f, ImageUrl = "", DateAdded = DateTime.Today, Quantity = 1 },
                new Product { Id = 2, Name = "Studio Speaker", Description = "Yamaha Studio Speaker", ModelNumber = "HS7", Price = 150.00f, ImageUrl = "", DateAdded = DateTime.Today, Quantity = 1 },
                new Product { Id = 3, Name = "Camping Cot", Description = "Folding Camping Cot", ModelNumber = "", Price = 50.00f, ImageUrl = "", DateAdded = DateTime.Today, Quantity = 1 },
                new Product { Id = 4, Name = "Bicycle", Description = "Koda Retrospec Bicycle", ModelNumber = "", Price = 40.00f, ImageUrl = "", DateAdded = DateTime.Today, Quantity = 1 },
                new Product { Id = 5, Name = "Hedge Trimmer", Description = "GreenWorks 24V Hedge Trimmer", ModelNumber = "", Price = 35.00f, ImageUrl = "", DateAdded = DateTime.Today, Quantity = 1 });
        }
    }
}