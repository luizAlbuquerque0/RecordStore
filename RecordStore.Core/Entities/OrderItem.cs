namespace RecordStore.Core.Entities
{
    public class OrderItem : BaseEntity
    {
        public OrderItem(int orderId, int recordId, string recordName, int amount, decimal totalCost)
        {
            OrderId = orderId;
            RecordId = recordId;
            RecordName = recordName;
            Amount = amount;
            TotalCost = totalCost;
        }

        public int OrderId { get; private set; }
        public int RecordId { get; private set; }
        public string RecordName { get; private set; }
        public int Amount { get; private set; }
        public decimal TotalCost { get; private set; }
        public User Store { get; private set; }
        public Record Record { get; private set; }
        public Order Order { get; private set; }
    }
}
