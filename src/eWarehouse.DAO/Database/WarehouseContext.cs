using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using eWarehouse.BLL.Interfaces;
using eWarehouse.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace eWarehouse.DAO.Database
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {



        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        
        

    }
}
