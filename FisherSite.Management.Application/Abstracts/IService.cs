using FisherSite.Management.Application.BaseAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Abstracts
{
    public interface IService<TDto> : IQueryableService<TDto>, IModifiableService<TDto>
    {
    }
}
