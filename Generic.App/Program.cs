using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.DataLayer;
using Generic.DataLayer.Context;
using Generic.DataLayer.Models;
using Generic.DataLayer.Repositories;
using Generic.DataLayer.Servises;

namespace Generic.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IPersonRepository personRepository = new PersonRepository(db);
            //personRepository.InsertPerson(new Person()
            //{
            //    Name = "Mohammad",
            //    Family = "Alizadeh",
            //    Mobile = "091000000"
            //});
            //personRepository.Save();

            //MyContext db = new MyContext();
            //MyGenericRepository<Person> personRepository = new MyGenericRepository<Person>(db);

            //var query = personRepository.Get(p=> p.Name.Contains("S"));

            //db.Dispose();
        }
    }
}
