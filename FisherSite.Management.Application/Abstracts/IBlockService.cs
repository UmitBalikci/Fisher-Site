using FisherSite.Domain;
using FisherSite.Management.Application.BaseAbstracts;
using FisherSite.Management.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Abstracts
{
    public interface IBlockService : IQueryableService<BlockDTO>
    {
    }
}
