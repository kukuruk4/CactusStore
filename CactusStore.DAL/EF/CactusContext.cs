using CactusStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CactusStore.DAL.EF
{
    public class CactusContext : DbContext
    {
        public DbSet<Cactus> Cactuses { get; set; }
        public DbSet<Order> Orders { get; set; }

        public CactusContext(DbContextOptions<CactusContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}