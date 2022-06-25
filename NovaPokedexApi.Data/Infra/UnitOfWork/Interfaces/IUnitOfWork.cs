﻿using NovaPokedexApi.Data.Infra.Repositories;

namespace NovaPokedexApi.Infra.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        void commit();
    }
}