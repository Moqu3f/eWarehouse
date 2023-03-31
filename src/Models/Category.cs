using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        private long id;
        private string name;
        private string description;

        public long Id
        {
            get => id; set => id = value;
        }

        public string Name
        {
            get => name; set => name = value;
        }

        public string Description
        {
            get => description; set => description = value;
        }

        public ICollection<Product> Products { get; set; }
    }

}
