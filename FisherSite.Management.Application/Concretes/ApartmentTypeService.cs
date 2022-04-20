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
    public class ApartmentTypeService : IApartmentTypeService
    {
        private readonly IApartmentTypeRepository _apartmentTypeRepository;

        public ApartmentTypeService(IApartmentTypeRepository apartmentTypeRepository)
        {
            _apartmentTypeRepository  = apartmentTypeRepository;
        }
        public IEnumerable<ApartmentTypeDTO> GetAll()
        {
            var apartmentTypes = _apartmentTypeRepository.GetAll();
            var apartmentTypeDTOs = new List<ApartmentTypeDTO>();
            foreach (var apartmentType in apartmentTypes)
            {
                apartmentTypeDTOs.Add(new ApartmentTypeDTO()
                {
                    Id = apartmentType.Id,
                    Name = apartmentType.Name,
                });
            }
            return apartmentTypeDTOs;
        }

        public ApartmentTypeDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
