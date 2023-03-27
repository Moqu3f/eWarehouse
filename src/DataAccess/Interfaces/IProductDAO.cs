using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IProductDAO
    {
        void Create(Product product);
        Product GetById(long id);
        List<Product> GetAll();
        void Update(Product product);
        void Delete(long id);
        List<Product> GetProductsByCategory(long categoryId);
        List<Product> GetProductsByProvider(long providerId);
    }
}
