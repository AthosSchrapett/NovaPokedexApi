using NovaPokedexApi.Models;

namespace NovaPokedexApi.Services
{
    public interface IUserService
    {
        List<User> UserGet();
        User UserGetById(Guid id);
        void UserPost(User User);
        void UserPut(Guid id, User User, User UserUpdated);
        void UserDelete(Guid id);
    }
}
