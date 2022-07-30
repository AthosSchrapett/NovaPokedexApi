using Microsoft.AspNetCore.Identity;
using NovaPokedexApi.Data.Infra.Repositories;
using NovaPokedexApi.Infra.Context;

namespace NovaPokedexApi.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Repositories
        private IUserRepository _userRepository;
        private IUserIdentityRepository _userIdentityRepository;
        #endregion

        #region Context
        private readonly PokeContext _pokeContext;
        //private readonly UserManager<IdentityUser> _userManager;
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

        public IUserIdentityRepository UserIdentityRepository
        {
            get
            {
                if (_userIdentityRepository == null)
                {
                     _userIdentityRepository = new UserIdentityRepository(_pokeContext);
                }
                return _userIdentityRepository;
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
