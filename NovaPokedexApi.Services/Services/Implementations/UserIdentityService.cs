using Microsoft.AspNetCore.Identity;
using NovaPokedexApi.Infra.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPokedexApi.Services
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserIdentityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<IdentityUser> UserGet()
        {
            throw new NotImplementedException();
        }

        public IdentityUser UserGetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IdentityUser UserGetByNameAndPassword(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public void UserPost(IdentityUser User)
        {
            _unitOfWork.UserIdentityRepository.Post(User);
            _unitOfWork.Commit();
        }

        public void UserPut(Guid id, IdentityUser User)
        {
            throw new NotImplementedException();
        }

        public void UserDelete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
