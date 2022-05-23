using NovaPokedexApi.Models;

namespace NovaPokedexApi.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> UserGet();
        User UserGetById(Guid id);
        User UserGetByNameAndPassword(string name, string password);
        void UserPost(User user);
        void UserUpdate(Guid id, User user);
        void UserDelete(Guid id);
    }
}
