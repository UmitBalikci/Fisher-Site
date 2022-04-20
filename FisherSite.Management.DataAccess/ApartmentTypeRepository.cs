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
    public class ApartmentTypeRepository : IApartmentTypeRepository
    {
        public IEnumerable<ApartmentType> GetAll()
        {
            var dbContext = new FisherSiteDbContext();
            return dbContext.ApartmentTypes.ToList();
        }

        public ApartmentType GetById(int id)
        {
            var dbContext = new FisherSiteDbContext();
            return dbContext.ApartmentTypes.Find(id);
        }
    }
}
