using RecordStore.Core.Entities;

namespace RecordStore.Application.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel(string userName,  decimal totalCost,  DateTime date)
        {
            UserName = userName;
            TotalCost = totalCost;
            Date = date;
        }

        public string UserName { get; private set; }
        public decimal TotalCost { get; private set; }
        public List<Record> Records { get; private set; }
        public DateTime Date { get; private set; }
    }
}
