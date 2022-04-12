using FisherSite.Domain;
using FisherSite.Management.Application.Repository;
using FisherSite.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        public void Create(Person person)
        {
            var dbContext = new FisherSiteDbContext();
            dbContext.Persons.Add(person);
            dbContext.SaveChanges();
        }

        public void Delete(Person person)
        {
            var dbContext = new FisherSiteDbContext();
            dbContext.Persons.Remove(person);
            dbContext.SaveChanges();
        }

        public IEnumerable<Person> GetAll()
        {
            var dbContext = new FisherSiteDbContext();
            return dbContext.Persons.ToList();
        }

        public Person GetById(int id)
        {
            var dbContext = new FisherSiteDbContext();
            return dbContext.Persons.Find(id);
        }

        public void Update(Person person)
        {
            var dbContext = new FisherSiteDbContext();
            dbContext.Persons.Update(person);
            dbContext.SaveChanges();
        }
    }
}
