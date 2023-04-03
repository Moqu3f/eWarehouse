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
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Електроніка", Description = "Технічні пристрої на основі електронних компонентів" },
                new Category { Id = 2, Name = "Одяг", Description = "Одяг та взуття для чоловіків, жінок та дітей" },
                new Category { Id = 3, Name = "Косметика", Description = "Косметичні засоби для догляду за шкірою обличчя та тіла" }
            );

            // Seed providers
            modelBuilder.Entity<Provider>().HasData(
                new Provider { Id = 1, Name = "ТОВ 'Електроніка'", Surname = "Новохатько", Address = "м. Київ, вул. Хрещатик, 1", Email = "info@electronics.com", Phone = "+380445551122", Description = "Замовлення від 10 товарів" },
                new Provider { Id = 2, Name = "ТОВ 'Модний світ'", Surname = "Потебня", Address = "м. Львів, вул. Галицька, 10", Email = "info@fashionworld.com", Phone = "+380322223344", Description = "Тільки предоплата" },
                new Provider { Id = 3, Name = "ТОВ 'Косметика краси'", Surname = "Каюк", Address = "м. Харків, вул. Сумська, 20", Email = "info@beautycosmetics.com", Phone = "+380577771111", Description = "Довга доставка" }
            );

            // Seed products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Смартфон Samsung Galaxy S21", Description = "Найновіший смартфон від Samsung з чудовим екраном та потужним процесором", Quantity = 50, CategoryId = 1, ProviderId = 1, Brand = "Samsung", Price = 23999, Customer = "Шиленко" },
                new Product { Id = 2, Name = "Чоловічі кросівки Nike Air Max", Description = "Комфортні та стильні кросівки для активного відпочинку", Quantity = 15, CategoryId = 2, ProviderId = 2, Brand = "Nike", Price = 1899, Customer = "Бартків" },
                new Product { Id = 3, Name = "Крем для обличчя Nivea", Description = "Зволожуючий крем для догляду за сухою та чутливою шкірою обличчя", Quantity = 20, CategoryId = 3, ProviderId = 3, Brand = "Nivea", Price = 99, Customer = "Асаула" }
            );

        }
    }

}
