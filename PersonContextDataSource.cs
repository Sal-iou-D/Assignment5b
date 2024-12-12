using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5b
{
    
    public class PersonContextDataSource : IPersonDataSource 
    {
        private readonly PersonContext _context;
        public PersonContextDataSource()
        {
            _context = new PersonContext();
            _context.Database.EnsureCreated();
            _context.People.Load();
        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.People.Local.ToBindingList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        

    }
}
