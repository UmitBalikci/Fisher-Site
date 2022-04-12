using FisherSite.Management.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Abstracts
{
    public interface IApartmentService
    {
        IEnumerable<ApartmentDTO> GetAll();
        void Create(ApartmentDTO apartmentDTO);
        void Update(ApartmentDTO apartmentDTO);
        void Delete(ApartmentDTO apartmentDTO);
        ApartmentDTO GetById(int id);
    }
}
