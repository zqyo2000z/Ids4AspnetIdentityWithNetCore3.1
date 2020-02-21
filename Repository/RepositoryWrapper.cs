using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.Manager;
using Contracts.Tenant;
using Entities;
using Entities.Models;

namespace Repository
{
  public   class RepositoryWrapper:IRepositoryWrapper
    {
        private readonly RepositoryContext _repoContext;
        private IOrderRepository _order;
        private IMerchantRepository _merchant;
        public RepositoryWrapper(RepositoryContext repoContext)
        {
            _repoContext = repoContext;
        }

        public IOrderRepository Order => _order ?? (_order = new OrderRepository(_repoContext));

        public async  void Save()
        {
            await _repoContext.SaveChangesAsync();
        }

        public IMerchantRepository Merchant => _merchant ?? (_merchant = new MerchantRepository(_repoContext));


    }
}
