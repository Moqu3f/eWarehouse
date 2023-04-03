using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        private long id;
        private string name;
        private string description;
        private int quantity;
        private long categoryId;
        private long providerId;
        private string brand;
        private decimal price;
        private string customer;

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

        public int Quantity
        {
            get => quantity; set => quantity = value;
        }

        public long CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public long ProviderId
        {
            get => providerId; set => providerId = value;
        }

        public string Brand
        {
            get => brand; set => brand = value;
        }

        public decimal Price
        {
            get => price; set => price = value;
        }

        public string Customer
        {
            get => customer; set => customer = value;
        }

        public Category Category { get; set; }
        public Provider Provider { get; set; }
    }

}
