using NovaPokedexApi.Data.Infra.Repositories;
using NovaPokedexApi.Infra.Context;

namespace NovaPokedexApi.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUserRepository _userRepository;

        private readonly PokeContext _pokeContext;

        public UnitOfWork(PokeContext pokeContext)
        {
            _pokeContext = pokeContext;
        }

        public IUserRepository UserRepository
        {
            get
            {
                if(_userRepository == null)
                {
                    _userRepository = new UserRepository(_pokeContext);
                }
                return _userRepository;
            }
        }

        public void commit()
        {
            _pokeContext.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
