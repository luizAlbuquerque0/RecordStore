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
            await _dbContext.Order.AddAsync(order);
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _dbContext.Order.SingleOrDefaultAsync(o => o.Id == id);
        }

        public async Task<List<Order>> GetStoreOrdersAsync(int storeId)
        {
            return await _dbContext.Order.Where(o => o.StoreId == storeId).ToListAsync();
        }

        public async Task<List<Order>> GetUserOrdersAsync(int userId)
        {
            return await _dbContext.Order.Where(o => o.UserId == userId).ToListAsync();
        }
    }
}
