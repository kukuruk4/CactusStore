using System;
using CactusStore.Domain.Entities;

namespace CactusStore.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Cactus> Cactuses { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}