using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        //TODO: ADD BRAND,PRICE
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Availability { get; set; }
        public long CategoryId { get; set; }
        public long ProviderId { get; set; }

        public Category Category { get; set; }
        public Provider Provider { get; set; }
    }
}
