using System;
using System.Collections.Generic;
using System.Linq;
using CactusStore.DAL.EF;
using CactusStore.DAL.Interfaces;
using CactusStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CactusStore.DAL.Repositories
{
    public class CactusRepository : IRepository<Cactus>
    {
        private CactusContext db;
 
        public CactusRepository(CactusContext context)
        {
            this.db = context;
        }
 
        public IEnumerable<Cactus> GetAll()
        {
            return db.Cactuses;
        }
 
        public Cactus Get(int id)
        {
            return db.Cactuses.Find(id);
        }
 
        public void Create(Cactus cactus)
        {
            db.Cactuses.Add(cactus);
        }
 
        public void Update(Cactus cactus)
        {
            db.Entry(cactus).State = EntityState.Modified;
        }
 
        public IEnumerable<Cactus> Find(Func<Cactus, Boolean> predicate)
        {
            return db.Cactuses.Where(predicate).ToList();
        }
 
        public void Delete(int id)
        {
            Cactus cactus = db.Cactuses.Find(id);
            if (cactus != null)
                db.Cactuses.Remove(cactus);
        }
    }
}