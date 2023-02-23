﻿using RecordStore.Core.Entities;

namespace RecordStore.Core.Repositories
{
    public interface IOrderRepository
    {
        Task CreateOrderAsync(Order order);
        Task<Order> GetOrderByIdAsync(int id);
        Task<List<Order>> GetOrdersAsync(int id);
        Task<List<Order>> GetStoreOrdersAsync(int storeId);
        Task<List<Order>> GetUserOrdersAsync(int userId);

    }
}
