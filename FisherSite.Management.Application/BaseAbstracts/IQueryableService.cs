using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.BaseAbstracts
{
    public interface IQueryableService<TDto>
    {
        IEnumerable<TDto> GetAll();
        TDto GetById(int id);
    }
}
