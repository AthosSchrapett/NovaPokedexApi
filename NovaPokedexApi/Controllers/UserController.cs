using Microsoft.AspNetCore.Mvc;
using NovaPokedexApi.Infra.Context;
using NovaPokedexApi.Infra.UnitOfWork;
using NovaPokedexApi.Models;
using NovaPokedexApi.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NovaPokedexApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly PokeContext _pokeContext;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(PokeContext pokeContext)
        {
            _pokeContext = pokeContext;
            _unitOfWork = new UnitOfWork(_pokeContext);
        }

        // GET: api/<UserController>
        [HttpGet]
        public IActionResult UserGet()
        {
            var users = _unitOfWork.UserRepository.UserGet();

            if(users == null)
                return NotFound();
            return Ok(users);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult UserGet(Guid id)
        {
            var user = _unitOfWork.UserRepository.UserGetById(id);

            if (user == null)
                return NotFound();
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public void UserPost([FromBody] User user)
        {
            _unitOfWork.UserRepository.UserPost(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void UserPut(Guid id, [FromBody] User user)
        {
            _unitOfWork.UserRepository.UserUpdate(id, user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void UserDelete(Guid id)
        {
            _unitOfWork.UserRepository.UserDelete(id);
        }
    }
}
