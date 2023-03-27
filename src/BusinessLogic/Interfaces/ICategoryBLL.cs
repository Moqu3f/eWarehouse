using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLogic.Interfaces
{
    public interface ICategoryBLL
    {
        void CreateCategory(Category category);
        Category GetCategoryById(long id);
        List<Category> GetAllCategories();
        void UpdateCategory(Category category);
        void DeleteCategory(long id);
    }
}
