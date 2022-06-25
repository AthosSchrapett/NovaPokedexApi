using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPokedexApi.Data.Infra.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> UserGet();
        T GetById(Guid id);
        void Post(T entity);
        void Update(Guid id, T entity, T entityUpdated);
        void Delete(Guid id);
    }
}
