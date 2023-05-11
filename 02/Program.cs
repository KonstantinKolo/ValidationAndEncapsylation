using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var personList = new List<Person>();

                string[] people = Console.ReadLine().Split(';').ToArray();
                foreach (var guy in people)
                {
                    string[] helper = guy.Split('=').ToArray();
                    Person person = new Person(helper[0], decimal.Parse(helper[1]));
                    personList.Add(person);
                    
                }

                var productList = new List<Product>();

                string productInfo = Console.ReadLine();
                if(productInfo[productInfo.Length - 1] == ';')
                {
                    productInfo = productInfo.Remove(productInfo.Length - 1);
                }

                string[] productArr = productInfo.Split(';').ToArray();
                foreach (var item in productArr)
                {
                    string[] proHelp = item.Split('=').ToArray();
                    Product product = new Product(proHelp[0], decimal.Parse(proHelp[1]));
                    productList.Add(product);
                }

                string commands = Console.ReadLine();
                string[] commandHelp;
                while (commands != "END")
                {
                    commandHelp = commands.Split(' ').ToArray();
                    var product = productList.FirstOrDefault(x => x.Name == commandHelp[1]);
                    try
                    {
                        personList.FirstOrDefault(x => x.Name == commandHelp[0]).AddProduct(product);
                        Console.WriteLine(personList.FirstOrDefault(x => x.Name == commandHelp[0]).Bag);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    commands = Console.ReadLine();
                }
                foreach(var person1 in personList)
                {
                    Console.Write($"{person1.Name} - ");
                    person1.Print(person1.CheckOut);
                    Console.WriteLine();
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
