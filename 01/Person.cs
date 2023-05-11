using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Person
    {
        private string name;
        private int age;
        private double rating;

        public string Name { get; set; }
        public int Age { get; set; }
        public double Rating { get; set; }

        public Person(string name, int age,double rating) 
        {
            this.Name = name;
            this.Age = age;
            this.Rating = rating;
        }
    }
}
