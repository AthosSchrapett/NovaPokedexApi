using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using NovaPokedexApi.Models;

namespace NovaPokedexApi.Services
{
    public interface ITokenService
    {
        string GenerateToken(IdentityUser user, IConfiguration configuration);
    }
}
