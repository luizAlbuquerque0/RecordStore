namespace RecordStore.Core.Repositories
{
    public interface ICartItemRepository
    {
        Task CreateCartItemAsync(int cartId, int recordId, int amount);
        Task GetAllByCartAsync(int cartId);
    }
}
