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
            var person = new Person()
            {
                Id = personDTO.Id,
                Name = personDTO.Name,
                IdentityNumber = personDTO.IdentityNumber,
                Email = personDTO.Email,
                Phone = personDTO.Phone,
                VehicleInfo = personDTO.VehicleInfo
            };
            _personRepository.Create(person);
        }

        public void Delete(PersonDTO personDTO)
        {
            var person = new Person()
            {
                Id = personDTO.Id,
                Name = personDTO.Name,
                IdentityNumber = personDTO.IdentityNumber,
                Email = personDTO.Email,
                Phone = personDTO.Phone,
                VehicleInfo = personDTO.VehicleInfo
            };
            _personRepository.Delete(person);
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

        public PersonDTO GetById(int id)
        {
            var person = _personRepository.GetById(id);
            var personDTO = new PersonDTO()
            {
                Id = person.Id,
                Name = person.Name,
                IdentityNumber = person.IdentityNumber,
                Email = person.Email,
                Phone = person.Phone,
                VehicleInfo = person.VehicleInfo
            };
            return personDTO;
        }

        public void Update(PersonDTO personDTO)
        {
            var person = new Person()
            {
                Id = personDTO.Id,
                Name = personDTO.Name,
                IdentityNumber = personDTO.IdentityNumber,
                Email = personDTO.Email,
                Phone = personDTO.Phone,
                VehicleInfo = personDTO.VehicleInfo
            };
            _personRepository.Update(person);
        }
    }
}
