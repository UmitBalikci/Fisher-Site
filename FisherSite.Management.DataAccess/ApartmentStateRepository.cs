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
    public class ApartmentStateRepository : IApartmentStateRepository
    {
        public IEnumerable<ApartmentState> GetAll()
        {
            var dbContext = new FisherSiteDbContext();
            return dbContext.ApartmentStates.ToList();
        }
    }
}
