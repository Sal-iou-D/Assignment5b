using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5b
{
    public class PersonListDataSource : IPersonDataSource
    {
        private readonly List<Person> _people;

        public PersonListDataSource()
        {
            _people = new List<Person>
        {
            new Person(1, "Sal Diop", "123-456-7890"),
            new Person(2, "James Newman", "234-567-8901"),
            new Person(3, "Charlie Carman", "345-678-9012")
        };
        }

        public IEnumerable<Person> GetPeople()
        {
            return _people.ToList(); 
        }

        public void SaveChanges()
        {
            
        }
    }
}
