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
        public DbSet<User> User { get; private set; }
        public DbSet<Record> Records { get; private set; }
        public DbSet<Order> Orders { get; private set; }
        public DbSet<Cart> Carts { get; private set; }
        public DbSet<CartItem> CartItens { get; private set; }
        public DbSet<OrderItem> OrderItem { get; private set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
