using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NovaPokedexApi.Infra.Context;
using NovaPokedexApi.Infra.UnitOfWork;
using NovaPokedexApi.Models;
using NovaPokedexApi.Services;

namespace NovaPokedexApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;

        public LoginController(IConfiguration configuration, ITokenService tokenService, IUserService userService)
        {
            _configuration = configuration;
            _tokenService = tokenService;
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<dynamic>> Authenticate(string userName, string password)
        {
            var usuarioEncontrado = _userService.UserGetByNameAndPassword(userName, password);

            if (usuarioEncontrado == null)
            {
                return NotFound();
            }

            var token = _tokenService.GenerateToken(usuarioEncontrado, _configuration);

            return Ok(new
            {
                user = usuarioEncontrado,
                token = token
            });
        }
    }
}
