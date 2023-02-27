using RecordStore.Core.Entities;

namespace RecordStore.Core.Repositories
{
    public interface ICartItemRepository
    {
        Task CreateCartItemAsync(CartItem cartItem);
    }
}
