using NovaPokedexApi.Infra.UnitOfWork;
using NovaPokedexApi.Models;

namespace NovaPokedexApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<User> UserGet()
        {
            return _unitOfWork.UserRepository.UserGet().ToList();
        }

        public User UserGetById(Guid id)
        {
            return _unitOfWork.UserRepository.GetById(id);
        }

        public void UserPost(User User)
        {
            _unitOfWork.UserRepository.Post(User);
            _unitOfWork.Commit();
        }

        public void UserPut(Guid id, User user)
        {
            var userFind = _unitOfWork.UserRepository.GetById(id);
            user.Id = id;

            _unitOfWork.UserRepository.Update(id, user, userFind);
            _unitOfWork.Commit();
        }

        public void UserDelete(Guid id)
        {
            _unitOfWork.UserRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public User UserGetByNameAndPassword(string userName, string password)
        {
            var userFind = _unitOfWork.UserRepository.UserGet().FirstOrDefault(x => x.UserName == userName && x.Password == password);

            return userFind;

        }
    }
}
