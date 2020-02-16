using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Contracts
{
  public   interface IManagerIndexRepository:IRepositoryBase<Order>
    {
        IEnumerable<Order > GetAllOrders();
    }
}
