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
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;
        public ApartmentService(IApartmentRepository apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }
        public void Create(ApartmentDTO apartmentDTO)
        {
            var apartment = new Apartment()
            {
                Id = apartmentDTO.Id,
                BlockId = apartmentDTO.BlockId,
                ApartmentStateId = apartmentDTO.ApartmentStateId,
                ApartmentTypeId = apartmentDTO.ApartmentTypeId,
                ApartmentFloor = apartmentDTO.ApartmentFloor,
                PersonId = apartmentDTO.PersonId
            };
            _apartmentRepository.Create(apartment);
        }

        public void Delete(ApartmentDTO apartmentDTO)
        {
            var deletedApartment = _apartmentRepository.GetById(apartmentDTO.Id);
            if (deletedApartment != null)
            {
                _apartmentRepository.Delete(deletedApartment);
            }

        }

        public IEnumerable<ApartmentDTO> GetAll()
        {
            var apartments = _apartmentRepository.GetAll();
            var apartmentDTOs = new List<ApartmentDTO>();
            foreach (var apartment in apartments)
            {
                apartmentDTOs.Add(new ApartmentDTO()
                {
                    Id = apartment.Id,
                    BlockId = apartment.BlockId,
                    ApartmentStateId = apartment.ApartmentStateId,
                    ApartmentTypeId = apartment.ApartmentTypeId,
                    ApartmentFloor = apartment.ApartmentFloor,
                    PersonId = apartment.PersonId,
                    Dues = apartment.Dues
                });
            }
            return apartmentDTOs;
        }

        public ApartmentDTO GetById(int id)
        {
            var apartment = _apartmentRepository.GetById(id);
            var apartmentDTO = new ApartmentDTO()
            {
                Id = apartment.Id,
                BlockId = apartment.BlockId,
                ApartmentStateId = apartment.ApartmentStateId,
                ApartmentTypeId = apartment.ApartmentTypeId,
                ApartmentFloor = apartment.ApartmentFloor,
                PersonId = apartment.PersonId
            };
            return apartmentDTO;
        }

        public void Update(ApartmentDTO apartmentDTO)
        {
            var apartment = _apartmentRepository.GetById(apartmentDTO.Id);
            apartment.Id = apartmentDTO.Id;
            apartment.BlockId = apartmentDTO.BlockId;
            apartment.ApartmentStateId = apartmentDTO.ApartmentStateId;
            apartment.ApartmentTypeId = apartmentDTO.ApartmentTypeId;
            apartment.ApartmentFloor = apartmentDTO.ApartmentFloor;
            apartment.PersonId = apartmentDTO.PersonId;
            _apartmentRepository.Update(apartment);
        }
    }
}
