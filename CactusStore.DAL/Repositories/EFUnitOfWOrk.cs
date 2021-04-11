using System;
using CactusStore.DAL.EF;
using CactusStore.DAL.Interfaces;
using CactusStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CactusStore.DAL.Repositories
{
    public class EFUnitOfWork
    {
        private CactusContext db;
        private CactusRepository cactusRepository;
        private OrderRepository orderRepository;

        public EFUnitOfWork(CactusContext context)
        {
            db = context;
        }
        public IRepository<Cactus> Phones
        {
            get
            {
                if (cactusRepository == null)
                    cactusRepository = new CactusRepository(db);
                return cactusRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}