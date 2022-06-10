using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.DataLayer.Context;
using Generic.DataLayer.Models;
using Generic.DataLayer.Repositories;

namespace Generic.DataLayer.Servises
{
    public class PersonRepository:IPersonRepository
    {
        private MyContext db;

        public PersonRepository(MyContext context)
        {
            db = context;
        }
        public List<Person> GetAllPerson()
        {
            return db.Persons.ToList();
        }

        public Person GetPersonById(int personId)
        {
            return db.Persons.Find(personId);
        }

        public void InsertPerson(Person person)
        {
            db.Persons.Add(person);
        }

        public void UpdatePerson(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
        }

        public void DeletePerson(Person person)
        {
            db.Entry(person).State = EntityState.Deleted;
        }

        public void DeletePerson(int personId)
        {
            var person = GetPersonById(personId);
            DeletePerson(person);
        }   

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
