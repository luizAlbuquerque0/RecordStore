namespace RecordStore.Application.ViewModels
{
    public class RecordViewModel
    {
        public RecordViewModel(string name, string description, string gender, decimal price, int storeId, int stock, string storeName)
        {
            Name = name;
            Description = description;
            Gender = gender;
            Price = price;
            StoreId = storeId;
            Stock = stock;
            StoreName = storeName;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Gender { get; private set; }
        public decimal Price { get; private set; }
        public int StoreId { get; private set; }
        public int Stock { get; private set; }
        public string StoreName { get; private set; }
    }
}
