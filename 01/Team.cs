using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person person)
        {
            if(person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }
        public IReadOnlyCollection<Person> FirstTeam
        {
           get { return this.firstTeam.AsReadOnly(); }
        }
        public IReadOnlyList<Person> ReserveTeam
        {
            get { return reserveTeam; }
        }

        public override string ToString()
        {
            return $"First team have {firstTeam.Count} players \nReserve team have {reserveTeam.Count} players.";
        }
    }
}
