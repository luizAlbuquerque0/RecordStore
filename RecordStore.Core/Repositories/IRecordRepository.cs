using RecordStore.Core.Entities;

namespace RecordStore.Core.Repositories
{
    public interface IRecordRepository
    {
        Task AddRecordAsync(Record record);
        Task DeleteRecordByIdAsync(int id);
        Task<Record> GetRecordByIdAsync(int id);
        Task UpdateRecordStockAsync(int id, int amount);
    }
}
