using Microsoft.EntityFrameworkCore;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Infrastructure.Persistence.Repositories
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly RecordStoreDbContext _dbContext;
        public CartItemRepository(RecordStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateCartItemAsync(CartItem cartItem)
        {
            await _dbContext.CarttItens.AddAsync(cartItem);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<CartItem> GetCartItemByIdAsync(int id)
        {
            return await _dbContext.CarttItens.SingleOrDefaultAsync(ci => ci.Id == id);
        }
    }
}
