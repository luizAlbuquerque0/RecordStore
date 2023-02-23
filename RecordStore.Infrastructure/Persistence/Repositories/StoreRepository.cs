using Microsoft.EntityFrameworkCore;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Infrastructure.Persistence.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly RecordStoreDbContext _dbContext;
        public StoreRepository(RecordStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateStoreAsync(Store store)
        {
            await _dbContext.Stores.AddAsync(store);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Store> GetByEmailAndPasswordAsync(string email, string password)
        {
            var store = await _dbContext.Stores.SingleOrDefaultAsync(s => s.Email == email && s.Password == password);
            return store;
        }

        public async Task<Store> GetByIdAsync(int id)
        {
            var store = await _dbContext.Stores.SingleOrDefaultAsync(s => s.Id == id);
            return store;
        }
    }
}
