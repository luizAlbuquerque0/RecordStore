using RecordStore.Core.Entities;

namespace RecordStore.Application.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel(int cartId, int userId, List<CartItem> cartItem)
        {
            CartId = cartId;
            UserId = userId;
            CartItem = cartItem;
            CartItem = cartItem;
        }

        public int CartId { get; private set; }
        public int UserId { get; private set; }
        public List<CartItem> CartItem { get; private set; }
    }
}
