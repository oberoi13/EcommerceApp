using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oberoi_991674132_FE.Models;

namespace Oberoi_991674132_FE.Data
{
    public class Oberoi_991674132_FEContext : DbContext
    {
        public Oberoi_991674132_FEContext(DbContextOptions<Oberoi_991674132_FEContext> options)
            : base(options)
        {
        }

        public DbSet<Oberoi_991674132_FE.Models.Categories> Categories { get; set; } = default!;

        public DbSet<Oberoi_991674132_FE.Models.Orders> Orders { get; set; } = default!;

        public DbSet<Oberoi_991674132_FE.Models.Products> Products { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryID = 1, CategoryName = "Electronics", Description = "Electronics products" },
                new Categories { CategoryID = 2, CategoryName = "Clothing", Description = "Clothing products" }
            );

            modelBuilder.Entity<Products>().HasData(
                new Products { ProductID = 1, ProductName = "Smartphone", CategoryID = 1, Unit = "Each", Price = 500 },
                new Products { ProductID = 2, ProductName = "Laptop", CategoryID = 1, Unit = "Each", Price = 1000 }
            );

            modelBuilder.Entity<Orders>().HasData(
                new Orders { OrderID = 1, ProductID = 1, Quantity = 2 },
               new Orders { OrderID = 2, ProductID = 2, Quantity = 1 }
            );
        }
    }
}
