using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5b
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Person(int id, string name, string phone) 
        { 
            Name = name;
            Phone = phone;
            Id = id;
        
        }

        public Person() 
        {
            Name = String.Empty;
            Phone = String.Empty;
            Id = 0;
        }
    }
}
