using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.BaseAbstracts
{
    public interface IModifiableService<TDto>
    {
        void Create(TDto dto);
        void Update(TDto dto);
        void Delete(TDto dto);
    }
}
