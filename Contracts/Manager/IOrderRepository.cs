using System.Collections.Generic;
using Entities.Models;

namespace Contracts.Manager
{
  public   interface IOrderRepository:IRepositoryBase<Order>
    {
        IEnumerable<Order > GetAllOrders();
    }
}
