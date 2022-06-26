using NovaPokedexApi.Models;

namespace NovaPokedexApi.Services
{
    public interface IUserService
    {
        List<User> UserGet();
        User UserGetById(Guid id);
        User UserGetByNameAndPassword(string UserName, string Password);
        void UserPost(User User);
        void UserPut(Guid id, User User);
        void UserDelete(Guid id);
    }
}
