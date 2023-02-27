using Microsoft.EntityFrameworkCore;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Infrastructure.Persistence.Repositories
{
    public class RecordRepository : IRecordRepository
    {
        private readonly RecordStoreDbContext _dbContext;
        public RecordRepository(RecordStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddRecordAsync(Record record)
        {
            await _dbContext.Records.AddRangeAsync(record);
        }

        public async Task DeleteRecordByIdAsync(int id)
        {
            var record = await _dbContext.Records.SingleOrDefaultAsync(r => r.Id == id);
            _dbContext.Remove(record);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Record> GetRecordByIdAsync(int id)
        {
            return await _dbContext.Records.Include(r=>r.Store.FullName).SingleOrDefaultAsync(r => r.Id == id);
        }

        public async Task UpdateRecordStockAsync(int id, int amount)
        {
            var record = await _dbContext.Records.SingleOrDefaultAsync(r => r.Id == id);
            await _dbContext.SaveChangesAsync();
        }
    }
}
