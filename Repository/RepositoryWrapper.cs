using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.Manager;
using Entities;
using Entities.Models;

namespace Repository
{
  public   class RepositoryWrapper:IRepositoryWrapper
    {
        private readonly RepositoryContext _repoContext;
        private IOrderRepository _order;
        private ITenantRepository _tenant;
        public RepositoryWrapper(RepositoryContext repoContext)
        {
            _repoContext = repoContext;
        }

        public IOrderRepository Order => _order ?? (_order = new OrderRepository(_repoContext));

        public void Save()
        {
            await _repoContext.SaveChangesAsync();
        }

        public ITenantRepository tenant => _tenant ?? (_tenant = new TenantRepository(_repoContext));


    }
}
