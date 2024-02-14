﻿using FastFoodTotem.Domain.Entities;
using FastFoodTotem.Domain.Enums;

namespace FastFoodTotem.Domain.Contracts.Repositories
{
    public interface IOrderRepository
    {
        Task AddOrderAsync(OrderEntity order, CancellationToken cancellationToken);
        Task EditOrderAsync(OrderEntity order, CancellationToken cancellationToken);
        Task<OrderEntity?> GetOrderAsync(int orderId, CancellationToken cancellationToken);
        Task<IEnumerable<OrderEntity>> GetAllAsync(CancellationToken cancellationToken);
        Task<IEnumerable<OrderEntity>> GetOrderByStatus(OrderStatus status, CancellationToken cancellationToken);
        Task<IEnumerable<OrderEntity>> GetPendingOrders(CancellationToken cancellationToken);
    }
}