using System.Data.Entity;
using CactusStore.DAL.Entities;

namespace CactusStore.DAL.EF
{
    public class CactusContext : DbContext
    {
        public DbSet<Cactus> Cactuses { get; set; }
        public DbSet<Order> Orders { get; set; }

        static CactusContext()
        {
            Database.SetInitializer<CactusContext>(new StoreDbInitializer());
        }
        public CactusContext(string connectionString)
            : base(connectionString)
        {
        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<CactusContext>
    {
        protected override void Seed(CactusContext db)
        {
            db.Cactuses.Add(new Cactus { Name = "Опунция", Country = "Америка", Price = 800 });
            db.Cactuses.Add(new Cactus { Name = "Эхинокактус Грузона", Country = "Мексика", Price = 550 });
            db.Cactuses.Add(new Cactus { Name = "Апорокактус плетевидный", Country = "Мексика", Price = 1100 });
            db.SaveChanges();
        }
    }
}