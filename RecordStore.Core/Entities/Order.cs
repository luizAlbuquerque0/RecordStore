namespace RecordStore.Core.Entities
{
    public class Order : BaseEntity
    {
        public Order(int userId, int storeId, List<Record> records, decimal totalPrice)
        {
            UserId = userId;
            StoreId = storeId;
            Date = DateTime.Now;
            Records = records;
            TotalPrice = totalPrice;
        }

        public int UserId { get; private set; }
        public int StoreId { get; private set; }
        public DateTime Date { get; private set; }
        public List<Record> Records { get; private set; }
        public decimal TotalPrice { get; private set; }
        public User User { get; private set; }
        public Store Store { get; private set; }

    }
}
