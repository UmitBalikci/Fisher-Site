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
    public class BlockRepository : IBlockRepository
    {
        public IEnumerable<Block> GetAll()
        {
            var dbContext = new FisherSiteDbContext();
            return dbContext.Blocks.ToList();
        }

        public Block GetById(int id)
        {
            var dbContext = new FisherSiteDbContext();
            return dbContext.Blocks.Find(id);
        }
    }
}
