﻿using RecordStore.Core.Entities;

namespace RecordStore.Application.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel(string userName, string storeName, decimal totalCost, List<Record> records, DateTime date)
        {
            UserName = userName;
            StoreName = storeName;
            TotalCost = totalCost;
            Records = records;
            Date = date;
        }

        public string UserName { get; private set; }
        public string StoreName { get; private set; }
        public decimal TotalCost { get; private set; }
        public List<Record> Records { get; private set; }
        public DateTime Date { get; private set; }
    }
}