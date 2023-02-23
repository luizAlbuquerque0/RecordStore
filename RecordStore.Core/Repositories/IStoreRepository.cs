using RecordStore.Core.Entities;

namespace RecordStore.Core.Repositories
{
    public interface IStoreRepository
    {
        Task CreateStoreAsync(Store store);
        Task<Store> GetByIdAsync(int id);
        Task<Store> GetByEmailAndPasswordAsync(string email, string password);
    }
}
