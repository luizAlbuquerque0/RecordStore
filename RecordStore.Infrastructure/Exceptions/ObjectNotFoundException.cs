namespace RecordStore.Infrastructure.Exceptions
{
    public class ObjectNotFoundException : Exception
    {

        public ObjectNotFoundException(string message) : base(message)
        { }
    }
}
