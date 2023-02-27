using RecordStore.Core.Entities;

namespace RecordStore.Core.Repositories
{
    public interface ICartRepository
    {
        Task CreateCartAsync(int userId);
        Task<Cart> GetCartAsync(int cartId);
    }
}
