using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.Core.Entities
{
    public class Record : BaseEntity
    {
        public Record(string name, string description, string gender, decimal price, int storeId, int stock)
        {
            Name = name;
            Description = description;
            Gender = gender;
            Price = price;
            StoreId = storeId;
            Stock = stock;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Gender { get; private set; }
        public decimal Price { get; private set; }
        public int StoreId { get; private set; }
        public int Stock { get; private set; }
        public User Store { get; private set; }
        public List<CartItem> CartItens { get; private set; }

        public void UpdateStock(int amount)
        {
            Stock += amount;
        }
    }
}
