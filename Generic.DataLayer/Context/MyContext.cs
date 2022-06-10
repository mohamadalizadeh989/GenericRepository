using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.DataLayer.Models;


namespace Generic.DataLayer.Context
{
    public class MyContext :DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
