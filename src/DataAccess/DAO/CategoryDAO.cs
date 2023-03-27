using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;

namespace DataAccess.DAO
{
    public class CategoryDAO : ICategoryDAO
    {
        private readonly eWarehouseDbContext _context;

        public CategoryDAO(eWarehouseDbContext context)
        {   
            _context = context;
        }

        public void Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public Category GetById(long id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var category = GetById(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}
