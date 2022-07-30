using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NovaPokedexApi.Services;

namespace NovaPokedexApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserIdentityController : ControllerBase
    {
        private readonly IUserIdentityService _userIdentityService;

        public UserIdentityController(IUserIdentityService userIdentityService)
        {
            _userIdentityService = userIdentityService;
        }

        [HttpPost]
        public void UserPost([FromBody] IdentityUser user)
        {
            _userIdentityService.UserPost(user);
        }
    }
}
