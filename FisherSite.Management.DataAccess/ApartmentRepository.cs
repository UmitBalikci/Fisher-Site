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
    public class ApartmentRepository : IApartmentRepository
    {
        public void Create(Apartment apartment)
        {
            var dbContext = new FisherSiteDbContext();
            dbContext.Apartments.Add(apartment);
            dbContext.SaveChanges();
        }

        public void Delete(Apartment apartment)
        {
            var dbContext = new FisherSiteDbContext();
            dbContext.Apartments.Remove(apartment);
            dbContext.SaveChanges();
        }

        public IEnumerable<Apartment> GetAll()
        {
            var dbContext = new FisherSiteDbContext();
            return dbContext.Apartments.ToList();
        }

        public Apartment GetById(int id)
        {
            var dbContext=new FisherSiteDbContext();
            return dbContext.Apartments.Find(id);
        }

        public void Update(Apartment apartment)
        {
            var dbContext = new FisherSiteDbContext();
            dbContext.Apartments.Update(apartment);
            dbContext.SaveChanges();
        }
    }
}
