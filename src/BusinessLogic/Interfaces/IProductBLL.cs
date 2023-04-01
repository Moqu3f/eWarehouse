using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductBLL
    {
        void CreateProduct(Product product);
        Product GetProductById(long id);
        List<Product> GetAllProducts();
        void UpdateProduct(Product product);
        void DeleteProduct(long id);


        List<Product> GetProductsSortedByName();
        List<Product> GetProductsSortedByBrand();
        List<Product> GetProductsSortedByPrice();
        List<Product> SearchProductsByKeyword(string keyword);
        List<Product> searchCustomerByProducts(string customer);
    }
}
