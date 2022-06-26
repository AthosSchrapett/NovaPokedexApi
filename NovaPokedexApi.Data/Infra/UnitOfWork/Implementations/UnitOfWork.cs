using NovaPokedexApi.Data.Infra.Repositories;
using NovaPokedexApi.Infra.Context;

namespace NovaPokedexApi.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Repositories
        private IUserRepository _userRepository;
        #endregion

        #region Context
        private readonly PokeContext _pokeContext;
        #endregion

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

        public void Commit()
        {
            _pokeContext.SaveChanges();
        }

        public void Dispose()
        {
            _pokeContext.Dispose();
        }
    }
}
