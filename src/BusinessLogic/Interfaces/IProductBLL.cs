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

        //TODO: ADD SORT NAME
        //TODO: ADD SORT BRAND
        //TODO: ADD SORT PRICE

        //TODO: FIND KEYWORD PRODUCT
        void CreateProduct(Product product);
        Product GetProductById(long id);
        List<Product> GetAllProducts();
        void UpdateProduct(Product product);
        void DeleteProduct(long id);
        
    }
}
