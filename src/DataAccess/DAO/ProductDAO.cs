using System.Collections.Generic;
using System.Linq;
using DataAccess.Context;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace eWarehouse.DataAccess
{
    public class ProductDAO : IProductDAO
    {
        private readonly eWarehouseDbContext _context;

        public ProductDAO(eWarehouseDbContext context)
        {
            _context = context;
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetById(long id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public List<Product> GetProductsByCategory(long categoryId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsByProvider(long providerId)
        {
            return _context.Products.Where(p => p.ProviderId == providerId).ToList();
        }
    }
}