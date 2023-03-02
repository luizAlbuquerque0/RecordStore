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
            var record = await _dbContext.Records.FindAsync(cartItem.RecordId) ?? 
                throw new ObjectNotFoundException($"Record with ID {cartItem.RecordId} not found.");


            var cart = await _dbContext.Carts.FindAsync(cartItem.CartId) ??
                 throw new ObjectNotFoundException($"Cart with ID {cartItem.CartId} not found.");


            var cost = record.Price * cartItem.Amount;
            cartItem.SetCost(cost);
            cartItem.SetName(record.Name);
            cart.UpdateCost(cost);

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
            if (cartItem == null) throw new ObjectNotFoundException($"Cart Item with ID {id} not found.");

            _dbContext.CarttItens.Remove(cartItem);
            await _dbContext.SaveChangesAsync();

            
        }
    }
}
