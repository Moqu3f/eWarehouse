using eWarehouse.BLL.Interfaces;
using eWarehouse.BLL.Models;

namespace BLL.Models
{
    public class Category:IIdentifiable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}