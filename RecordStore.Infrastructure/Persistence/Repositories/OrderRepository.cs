using Microsoft.EntityFrameworkCore;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Infrastructure.Persistence.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly RecordStoreDbContext _dbContext;
        public OrderRepository(RecordStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateOrderAsync(Order order)
        {
            await _dbContext.Orders.AddAsync(order);
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _dbContext.Orders.Where(o => o.Id ==id).Include(o => o.User.FullName).Include(o => o.Store.FullName).SingleOrDefaultAsync();
        }

        public async Task<List<Order>> GetUserOrdersAsync(int id)
        {
            return await _dbContext.Orders.Where(o => o.UserId == id || o.StoreId == id).ToListAsync();
        }
    }
}
