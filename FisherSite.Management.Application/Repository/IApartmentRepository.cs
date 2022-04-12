using FisherSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Repository
{
    public interface IApartmentRepository
    {
        IEnumerable<Apartment> GetAll();
        void Create(Apartment apartment);
        void Update(Apartment apartment);
        void Delete(Apartment apartment);
        Apartment GetById(int id);
    }
}
