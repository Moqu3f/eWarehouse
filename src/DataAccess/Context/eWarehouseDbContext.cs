using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccess.Context
{
    public class eWarehouseDbContext : DbContext
    {
        public eWarehouseDbContext(DbContextOptions<eWarehouseDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed data for Category class
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Category1", Description = "Description1" },
                new Category { Id = 2, Name = "Category2", Description = "Description2" }
            );

            // seed data for Provider class
            modelBuilder.Entity<Provider>().HasData(
                new Provider { Id = 1, Name = "Provider1", Address = "Address1", Email = "Email1", Phone = "Phone1", Description = "Description1", Surname = "Surname2" ,},
                new Provider { Id = 2, Name = "Provider2", Address = "Address2", Email = "Email2", Phone = "Phone2", Description = "Description2",Surname = "Surname2"}
            );

            // seed data for Product class
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product1", Description = "Description1", Availability = true, CategoryId = 1, ProviderId = 1 , Customer = "Customer1",Brand = "Brand1",Price = 1999},
                new Product { Id = 2, Name = "Product2", Description = "Description2", Availability = false, CategoryId = 1, ProviderId = 1, Customer = "Customer2", Brand = "Brand2", Price = 2999 },
                new Product { Id = 3, Name = "Product3", Description = "Description3", Availability = true, CategoryId = 2, ProviderId = 2, Customer = "Customer3", Brand = "Brand3", Price = 3999 }
            );
        }
    }

}
