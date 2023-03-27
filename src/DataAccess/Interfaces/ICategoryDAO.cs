using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ICategoryDAO
    {
        void Create(Category category);
        Category GetById(long id);
        List<Category> GetAll();
        void Update(Category category);
        void Delete(long id);
    }
}
