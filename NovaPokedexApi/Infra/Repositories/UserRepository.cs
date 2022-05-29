using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovaPokedexApi.Infra.Context;
using NovaPokedexApi.Infra.UnitOfWork;
using NovaPokedexApi.Models;

namespace NovaPokedexApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PokeContext _pokeContext;
        private readonly IUnitOfWork _unitOfWork;

        public UserRepository(PokeContext pokeContext)
        {
            _pokeContext = pokeContext;
        }

        public IEnumerable<User> UserGet()
        {
            return _pokeContext.Users.ToList();
        }
        public User UserGetById(Guid id)
        {
            return _pokeContext.Users.Find(id);
        }
        public void UserPost(User user)
        {
            _pokeContext.Users.Add(user);
            _unitOfWork.commit();
        }
        public void UserUpdate(Guid id, User user)
        {
            var UserEncontrado = _pokeContext.Users.Find(id);

            UserEncontrado.UserName = user.UserName;
            UserEncontrado.Password = user.Password;

            _pokeContext.Entry(UserEncontrado).State = EntityState.Modified;
            _unitOfWork.commit();
        }
        public void UserDelete(Guid id)
        {
            User user = _pokeContext.Users.Find(id);
            _pokeContext.Remove(user);
            _unitOfWork.commit();
        }

        public User UserGetByNameAndPassword(string name, string password)
        {
            User userEncontrado = _pokeContext.Users.FirstOrDefault(x => x.UserName == name);

            if (userEncontrado.UserName != name || userEncontrado.Password != password)
            {
                return userEncontrado = new User();
            }

            return userEncontrado;                
        }
    }
}
