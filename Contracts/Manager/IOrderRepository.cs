using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Manager
{
  public   interface IOrderRepository:IRepositoryBase<Order>
    {
         Task<IEnumerable<Order >> GetAllOrdersAsync();
    }
}
