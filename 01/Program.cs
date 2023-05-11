using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] input;
            Team team = new Team("Plovidv");
            for (int s1 = 0; s1 < count; s1++)
            {
                input = Console.ReadLine().Split().ToArray();
                Person person = new Person(input[0] + " " + input[1], int.Parse(input[2]), double.Parse(input[3]));
                team.AddPlayer(person);
            }
            Console.WriteLine(team) ;
        }
    }
}
