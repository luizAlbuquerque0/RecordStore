namespace RecordStore.Core.Entities
{
    public class CartItem : BaseEntity
    {
        public CartItem(int cartId, int recordId, int amount)
        {
            CartId = cartId;
            RecordId = recordId;
            Amount = amount;
        }

        public int CartId { get; private set; }
        public int RecordId { get; private set; }
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public decimal Cost { get; private set; }
        public Cart Cart { get; private set; }
        public Record Record { get; private set; }
        public User Store { get; private set; }

        public void SetCost(decimal cost)
        {
            Cost = cost;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetStore(User store)
        {
            Store = store;
        }

    }
}
