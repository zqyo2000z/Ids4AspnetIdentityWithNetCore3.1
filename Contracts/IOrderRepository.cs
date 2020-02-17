using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Contracts
{
  public   interface IOrderRepository:IRepositoryBase<Order>
    {
        IEnumerable<Order > GetAllOrders();
    }
}
