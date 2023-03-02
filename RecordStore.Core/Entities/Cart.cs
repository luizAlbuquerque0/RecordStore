namespace RecordStore.Core.Entities
{
    public class Cart : BaseEntity
    {
        public Cart(int userId)
        {
            UserId = userId;
            TotalCost = 0;
        }

        public int UserId { get; private set; }
        public decimal TotalCost { get; private set; }
        public List<CartItem> CartItem { get; private set; }
        public User User { get; private set; }
        public Order Order { get; private set; }

        public void UpdateCost(decimal cost)
        {
            TotalCost += cost;
        }
    }
}
