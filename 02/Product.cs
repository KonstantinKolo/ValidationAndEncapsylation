using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Product
    {
        private string name;
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                price = value;
            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty ");
                }
                name = value;
            }
        }
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
