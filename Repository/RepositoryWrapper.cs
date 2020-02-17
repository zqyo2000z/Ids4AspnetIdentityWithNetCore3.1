using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
  public   class RepositoryWrapper:IRepositoryWrapper
    {
        private readonly RepositoryContext _repoContext;
        private IOrderRepository _order;

        public RepositoryWrapper(RepositoryContext repoContext)
        {
            _repoContext = repoContext;
        }

        public IOrderRepository Order => _order ?? (_order = new OrderRepository(_repoContext));

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
