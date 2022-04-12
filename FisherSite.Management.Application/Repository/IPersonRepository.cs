using FisherSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Repository
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        void Create(Person person);
        void Update(Person person);
        void Delete(Person person);
        Person GetById(int id);
    }
}
