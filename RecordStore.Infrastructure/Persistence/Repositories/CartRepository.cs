using Microsoft.EntityFrameworkCore;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;
using RecordStore.Infrastructure.Exceptions;

namespace RecordStore.Infrastructure.Persistence.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly RecordStoreDbContext _dbContext;
        public CartRepository(RecordStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateCartAsync(Cart cart)
        {
            await _dbContext.Carts.AddAsync(cart);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCartAsync(int cartId)
        {
            var cart = await _dbContext.Carts.SingleOrDefaultAsync(c => c.Id == cartId);
            if (cart == null) throw new ObjectNotFoundException($"Cart  with ID {cartId} not found.");

            _dbContext.Carts.Remove(cart);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<Cart> GetCartAsync(int cartId)
        {
            var cart = await _dbContext.Carts.Include(c => c.CartItem).SingleOrDefaultAsync(c => c.Id == cartId);
            return cart;
        }
    }
}
