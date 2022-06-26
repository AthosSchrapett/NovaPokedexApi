using NovaPokedexApi.Data.Infra.Repositories;

namespace NovaPokedexApi.Infra.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        void Commit();
    }
}
