using RecordStore.Core.Entities;

namespace RecordStore.Core.Repositories
{
    public interface ICartRepository
    {
        Task CreateCartAsync(Cart cart);
        Task<Cart> GetCartAsync(int cartId);
    }
}
