namespace RecordStore.Core.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Phone { get; private set; }
        public List<Record> Records { get; private set; }

    }
}
