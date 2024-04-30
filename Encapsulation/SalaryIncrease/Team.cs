using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrease
{
    public class Team
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
        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return firstTeam.AsReadOnly(); }
        }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return reserveTeam.AsReadOnly(); }
        }
        public void Add(Person person)
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
        public override string ToString()
        {
            return $"First team has {FirstTeam.Count()} players.\nReserve team has {reserveTeam.Count()} players.";
        }
    }
}
