using BLL.Models;
using eWarehouse.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWarehouse.BLL.Models
{
    public class Product : IIdentifiable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Availability { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public long ProviderId { get; set; }
        public Provider Provider { get; set; }
    }
}
