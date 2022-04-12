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
            throw new NotImplementedException();
        }

        public void Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            var dbContext = new FisherSiteDbContext();
            return dbContext.Persons.ToList();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
