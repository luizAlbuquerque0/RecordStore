namespace RecordStore.Application.ViewModels
{
    public class CartItemViewModel
    {
        public CartItemViewModel(int cartId, int recordId, int amount)
        {
            CartId = cartId;
            RecordId = recordId;
            Amount = amount;
        }

        public int CartId { get; private set; }
        public int RecordId { get; private set; }
        public int Amount { get; private set; }
    }
}
