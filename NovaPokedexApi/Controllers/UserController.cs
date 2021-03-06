using Microsoft.AspNetCore.Mvc;
using NovaPokedexApi.Infra.Context;
using NovaPokedexApi.Infra.UnitOfWork;
using NovaPokedexApi.Models;
using NovaPokedexApi.Services;

namespace NovaPokedexApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult UserGet()
        {
            var users = _userService.UserGet();

            if (users == null)
                return NotFound();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult UserGet(Guid id)
        {
            var user = _userService.UserGetById(id);

            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public void UserPost([FromBody] User user)
        {
            _userService.UserPost(user);
        }

        [HttpPut("{id}")]
        public void UserPut(Guid id, [FromBody] User user)
        {
            _userService.UserPut(id, user);
        }

        [HttpDelete("{id}")]
        public void UserDelete(Guid id)
        {
            _userService.UserDelete(id);
        }
    }
}
