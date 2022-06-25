using NovaPokedexApi.Models;

namespace NovaPokedexApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork; 

        public void UserDelete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<User> UserGet()
        {
            throw new NotImplementedException();
        }

        public User UserGetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UserPost(User User)
        {
            throw new NotImplementedException();
        }

        public void UserPut(Guid id, User User, User UserUpdated)
        {
            throw new NotImplementedException();
        }
    }
}
