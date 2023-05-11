using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;
        private List<Product> checkOut;

        public Person (string name,decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
            this.checkOut = new List<Product>();
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get { return money; }
            set
            {
                if(money < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }


        public void AddProduct(Product product)
        {
            if(product.Price > this.Money)
            {
                throw new ArgumentException($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                bag.Add(product);
                checkOut.Add(product);
                this.Money -= product.Price;
                Console.WriteLine($"{this.Name} has bought {product.Name}");
            }
        }
        public IReadOnlyList<Product> Bag
        {
            get { return bag; }
        }
        public List<Product> CheckOut
        {
            get { return checkOut; }
        }
        public void Print(List<Product> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
    }
}
