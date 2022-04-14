using FisherSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Repository
{
    public interface IBlockRepository
    {
        IEnumerable<Block> GetAll();
    }
}
