namespace RecordStore.Core.Entities
{
    public class Cart : BaseEntity
    {
        public Cart(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; private set; }
        public decimal TotalCost { get; private set; }
        public List<CartItem> CartItem { get; private set; }
        public User User { get; private set; }
    }
}
