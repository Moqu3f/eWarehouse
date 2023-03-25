using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eWarehouse.BLL.Interfaces;

namespace eWarehouse.BLL.Models
{
    public class Provider : IIdentifiable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
