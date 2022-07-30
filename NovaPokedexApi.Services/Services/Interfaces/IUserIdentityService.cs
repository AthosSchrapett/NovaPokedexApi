using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPokedexApi.Services
{
    public interface IUserIdentityService
    {
        List<IdentityUser> UserGet();
        IdentityUser UserGetById(Guid id);
        IdentityUser UserGetByNameAndPassword(string UserName, string Password);
        void UserPost(IdentityUser User);
        void UserPut(Guid id, IdentityUser User);
        void UserDelete(Guid id);
    }
}
