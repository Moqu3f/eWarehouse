using DAO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using eWarehouse.DAO.Database;

namespace eWarehouse.DAO.Repositories.Repo
{
    public class ProductRepo: BaseRepo<Category>
    {
        public ProductRepo(WarehouseContext context) : base(context)
        {
            Table = context.Category;
        }

    }
}