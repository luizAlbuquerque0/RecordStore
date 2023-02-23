using Microsoft.EntityFrameworkCore;
using RecordStore.Core.Entities;
using System.Reflection;

namespace RecordStore.Infrastructure.Persistence
{
    public class RecordStoreDbContext : DbContext
    {
        public RecordStoreDbContext(DbContextOptions<RecordStoreDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; private set; }
        public DbSet<Store> Stores { get; private set; }
        public DbSet<Record> Records { get; private set; }
        public DbSet<Order> Order { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
