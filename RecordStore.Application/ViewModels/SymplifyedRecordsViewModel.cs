namespace RecordStore.Application.ViewModels
{
    public class SymplifyedRecordsViewModel
    {
        public SymplifyedRecordsViewModel(int orderId, decimal totalCost, DateTime date)
        {
            OrderId = orderId;
            TotalCost = totalCost;
            Date = date;
        }

        public int OrderId { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime Date { get; private set; }
    }
}
