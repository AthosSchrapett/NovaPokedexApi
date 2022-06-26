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
        private readonly PokeContext _pokeContext;
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;

        public LoginController(PokeContext pokeContext, IConfiguration configuration)
        {
            _pokeContext = pokeContext;
            _configuration = configuration;
            _unitOfWork = new UnitOfWork(_pokeContext);
        }

        //[HttpPost]
        //public async Task<ActionResult<dynamic>> Authenticate([FromBody] User user)
        //{
        //    var usuarioEncontrado = _unitOfWork.UserRepository.UserGetByNameAndPassword(user.UserName, user.Password);

        //    if(usuarioEncontrado.UserName == null || usuarioEncontrado.Password == null)
        //    {
        //        return NotFound();
        //    }

        //    var token = TokenService.GenerateToken(usuarioEncontrado, _configuration);

        //    return Ok(new
        //    {
        //        user = usuarioEncontrado,
        //        token = token
        //    });
        //}
    }
}
