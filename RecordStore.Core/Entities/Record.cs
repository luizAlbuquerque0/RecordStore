using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.Core.Entities
{
    public class Record : BaseEntity
    {
        public Record(string name, string description, string gender, decimal price, int storeId, int initialStock)
        {
            Name = name;
            Description = description;
            Gender = gender;
            Price = price;
            StoreId = storeId;
            Stock = initialStock;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Gender { get; private set; }
        public decimal Price { get; private set; }
        public int StoreId { get; private set; }
        public int Stock { get; private set; }
    }
}
