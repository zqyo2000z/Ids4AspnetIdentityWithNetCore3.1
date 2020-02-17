using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
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
            throw new NotImplementedException();
        }
    }
}
