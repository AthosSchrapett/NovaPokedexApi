using NovaPokedexApi.Infra.Context;

namespace NovaPokedexApi.Data.Infra.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        private readonly PokeContext _pokeContext;

        public Repository(PokeContext pokeContext)
        {
            _pokeContext = pokeContext;
        }

        public T GetById(Guid id)
        {
            return _pokeContext.Set<T>().Find(id);
        }

        public void Post(T entity)
        {
            _pokeContext.Set<T>().Add(entity);
        }

        public void Update(Guid id, T entity, T entityUpdated)
        {
            _pokeContext.Entry(entity).CurrentValues.SetValues(entityUpdated);
        }

        public IEnumerable<T> UserGet()
        {
            return _pokeContext.Set<T>();
        }

        public void Delete(Guid id)
        {
            var entity = _pokeContext.Set<T>().Find(id);
            _pokeContext.Set<T>().Remove(entity);
        }
    }
}
