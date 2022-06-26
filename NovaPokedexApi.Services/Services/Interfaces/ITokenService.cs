using Microsoft.Extensions.Configuration;
using NovaPokedexApi.Models;

namespace NovaPokedexApi.Services
{
    public interface ITokenService
    {
        string GenerateToken(User user, IConfiguration configuration);
    }
}
