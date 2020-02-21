using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.DTO;
using Entities.Helpers;
using Entities.Models;

namespace Contracts.Manager
{
  public   interface IOrderRepository:IRepositoryBase<Order>
    {
         Task<IEnumerable<Order >> GetOrdersAsync();

         Task<PagedList<Order>> GetOrdersAsync(OrderParameters orderParameters);
    }
}
