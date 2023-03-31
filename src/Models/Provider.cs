using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Provider
    {
        private long id;
        private string name;
        private string surname;
        private string address;
        private string email;
        private string phone;
        private string description;

        public long Id
        {
            get => id; set => id = value;
        }

        public string Name
        {
            get => name; set => name = value;
        }

        public string Surname
        {
            get => surname; set => surname = value;
        }

        public string Address
        {
            get => address; set => address = value;
        }

        public string Email
        {
            get => email; set => email = value;
        }

        public string Phone
        {
            get => phone; set => phone = value;
        }

        public string Description
        {
            get => description; set => description = value;
        }

        public ICollection<Product> Products { get; set; }
    }
}
