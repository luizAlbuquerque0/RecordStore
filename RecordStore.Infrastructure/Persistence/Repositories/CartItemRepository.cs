using Microsoft.EntityFrameworkCore;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;
using RecordStore.Infrastructure.Exceptions;

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

        public async Task RemoveCartItemAsync(int id)
        {
            var cartItem = await _dbContext.CarttItens.SingleOrDefaultAsync(ci => ci.Id == id);
            if (cartItem == null) throw new CartItemNotFoundException();

            _dbContext.CarttItens.Remove(cartItem);
            await _dbContext.SaveChangesAsync();

            
        }
    }
}
