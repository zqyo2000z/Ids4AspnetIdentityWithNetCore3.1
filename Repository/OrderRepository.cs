using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Manager;
using Entities;
using Entities.Models;

namespace Repository
{
   public  class OrderRepository:RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return FindAll().OrderBy(o => o.Id).ToList();
        }
    }
}
