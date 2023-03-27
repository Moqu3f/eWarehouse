using System;
using System.Collections.Generic;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Models;

namespace eWarehouse.BusinessLogic
{
    public class CategoryBLL : ICategoryBLL
    {
        private readonly ICategoryDAO _categoryDAO;

        public CategoryBLL(ICategoryDAO categoryDAO)
        {
            _categoryDAO = categoryDAO;
        }

        public void CreateCategory(Category category)
        {
            try
            {
                _categoryDAO.Create(category);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating category", ex);
            }
        }

        public Category GetCategoryById(long id)
        {
            try
            {
                return _categoryDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting category", ex);
            }
        }

        public List<Category> GetAllCategories()
        {
            try
            {
                return _categoryDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting all categories", ex);
            }
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                _categoryDAO.Update(category);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating category", ex);
            }
        }

        public void DeleteCategory(long id)
        {
            try
            {
                _categoryDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting category", ex);
            }
        }
    }
}