using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Contracts.Manager;
using Contracts.Tenant;

namespace Contracts
{
   public  interface  IRepositoryWrapper
    {
        IOrderRepository Order { get; }

        void Save();

       IMerchantRepository Merchant { get; }

    }
}
