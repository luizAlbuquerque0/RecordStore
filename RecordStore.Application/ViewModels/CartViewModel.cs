using RecordStore.Core.Entities;

namespace RecordStore.Application.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel(int cartId, int userId, List<CartItemViewModel> cartItem, decimal totalCost)
        {
            CartId = cartId;
            UserId = userId;
            CartItem = cartItem;
            TotalCost = totalCost;
        }

        public int CartId { get; private set; }
        public int UserId { get; private set; }
        public List<CartItemViewModel> CartItem { get; private set; }
        public decimal TotalCost { get; private set; }
    }
}
