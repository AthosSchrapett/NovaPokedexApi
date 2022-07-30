using Microsoft.AspNetCore.Identity;
using NovaPokedexApi.Infra.Context;

namespace NovaPokedexApi.Data.Infra.Repositories
{
    public class UserIdentityRepository : Repository<IdentityUser>, IUserIdentityRepository
    {
        public UserIdentityRepository(PokeContext pokeContext) : base(pokeContext)
        {
        }
    }
}
