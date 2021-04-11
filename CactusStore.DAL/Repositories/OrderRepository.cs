using System;
using System.Collections.Generic;
using System.Linq;
using CactusStore.DAL.EF;
using CactusStore.DAL.Interfaces;
using CactusStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CactusStore.DAL.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private CactusContext db;

        public OrderRepository(CactusContext context)
        {
            this.db = context;
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Orders.Include(o => o.Cactus);
        }

        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public void Create(Order order)
        {
            db.Orders.Add(order);
        }

        public void Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
        }
        public IEnumerable<Order> Find(Func<Order, Boolean> predicate)
        {
            return db.Orders.Include(o => o.Cactus).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Order order = db.Orders.Find(id);
            if (order != null)
                db.Orders.Remove(order);
        }
    }
}