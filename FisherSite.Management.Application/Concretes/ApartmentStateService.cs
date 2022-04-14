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
    public class ApartmentStateService : IApartmentStateService
    {
        private readonly IApartmentStateRepository _apartmentStateRepository;

        public ApartmentStateService(IApartmentStateRepository apartmentStateRepository)
        {
            _apartmentStateRepository = apartmentStateRepository;
        }
        public IEnumerable<ApartmentStateDTO> GetAll()
        {
            var apartmentStates = _apartmentStateRepository.GetAll();
            var apartmentStateDTOs = new List<ApartmentStateDTO>();
            foreach (var apartmentState in apartmentStates)
            {
                apartmentStateDTOs.Add(new ApartmentStateDTO()
                {
                    Id = apartmentState.Id,
                    Name = apartmentState.Name,
                });
            }
            return apartmentStateDTOs;
        }
    }
}
