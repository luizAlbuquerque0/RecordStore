using RecordStore.Core.Enums;

namespace RecordStore.Core.Entities
{
    public class Order : BaseEntity
    {
        public Order(int userId, int cartId, decimal totalPrice)
        {
            UserId = userId;
            Date = DateTime.Now;
            CartId = cartId;
            Status = OrderStatusEnum.Created;
            TotalPrice = totalPrice;
        }

        public int UserId { get; private set; }
        public DateTime Date { get; private set; }
        public int CartId { get; private set; }
        public decimal TotalPrice { get; private set; }
        public OrderStatusEnum Status { get; private set; }
        public User User { get; private set; }
        public User Store { get; private set; }
        public Cart Cart { get; private set; }
        public List<CartItem> OrderItens { get; private set; }

        public void SetCartItens(List<CartItem> cartItens)
        {
            OrderItens = cartItens;
        }

    }
}
