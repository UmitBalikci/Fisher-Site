using FisherSite.Management.Application.BaseAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Repository
{
    public interface IRepository<TEntity> : IModifiableRepository<TEntity>, IQueryableRepository<TEntity>
    {
    }
}
