namespace RecordStore.Infrastructure.Exceptions
{
    public class CartItemNotFoundException : Exception
    {
        public CartItemNotFoundException() : base("Cart Item Not found")
        {}

        public CartItemNotFoundException(string message) : base(message)
        { }
    }
}
