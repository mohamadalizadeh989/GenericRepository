using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.DataLayer.Models;

namespace Generic.DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        private MyContext db = new MyContext();

        private MyGenericRepository<Person> _personRepository;

        public MyGenericRepository<Person> PersonRepository
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new MyGenericRepository<Person>(db);
                }

                return _personRepository;
            }
        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}
