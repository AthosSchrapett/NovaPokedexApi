using Microsoft.EntityFrameworkCore;
using NovaPokedexApi.Infra.Context;
using NovaPokedexApi.Infra.UnitOfWork;
using NovaPokedexApi.Models;

namespace NovaPokedexApi.Data.Infra.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(PokeContext pokeContext) : base(pokeContext)
        {
        }
    }
}
