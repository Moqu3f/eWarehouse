using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Models;

namespace BusinessLogic.BLL
{
    public class ProductBLL : IProductBLL
    {
        private readonly IProductDAO _productDAO;

        public ProductBLL(IProductDAO productDAO)
        {
            _productDAO = productDAO;
        }

        public void CreateProduct(Product product)
        {
            try
            {
                _productDAO.Create(product);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating product", ex);
            }
        }

        public Product GetProductById(long id)
        {
            try
            {
                return _productDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting product by id", ex);
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                return _productDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting all products", ex);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                _productDAO.Update(product);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating product", ex);
            }
        }

        public void DeleteProduct(long id)
        {
            try
            {
                _productDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting product", ex);
            }
        }



        public List<Product> GetProductsSortedByName()
        {
            return _productDAO.GetAll().OrderBy(p => p.Name).ToList();
        }

        public List<Product> GetProductsSortedByBrand()
        {
            return _productDAO.GetAll().OrderBy(p => p.Brand).ToList();
        }

        public List<Product> GetProductsSortedByPrice()
        {
            return _productDAO.GetAll().OrderBy(p => p.Price).ToList();
        }

        public List<Product> SearchProductsByKeyword(string keyword)
        {
            return _productDAO.GetAll().Where(p => p.Name.ToLower().Contains(keyword.ToLower()) || p.Brand.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public List<Product> searchCustomerByProducts(string customer)
        {
            return _productDAO.GetAll().Where(p => p.Customer.ToLower().Contains(customer.ToLower())).ToList();
        }
    }
}
