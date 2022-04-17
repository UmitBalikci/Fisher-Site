using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Abstracts
{
    public interface IService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        void Create(TEntity person);
        void Update(TEntity person);
        void Delete(TEntity person);
        TEntity GetById(int id);
    }
}
