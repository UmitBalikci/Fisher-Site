using FisherSite.Domain;
using FisherSite.Management.Application.Abstracts;
using FisherSite.Management.Application.DTOs;
using FisherSite.Management.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Concretes
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public void Create(PersonDTO personDTO)
        {
            throw new NotImplementedException();
        }

        public void Delete(PersonDTO personDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonDTO> GetAll()
        {
            var persons = _personRepository.GetAll();
            var personDTOs = new List<PersonDTO>();
            foreach (var person in persons)
            {
                personDTOs.Add(new PersonDTO()
                {
                    Id = person.Id,
                    Name = person.Name,
                    IdentityNumber = person.IdentityNumber,
                    Email = person.Email,
                    Phone = person.Phone,
                    VehicleInfo = person.VehicleInfo
                });
            }
            return personDTOs;
        }

        public void Update(PersonDTO personDTO)
        {
            throw new NotImplementedException();
        }
    }
}
