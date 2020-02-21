using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
   public  interface  IRepositoryWrapper
    {
        IOrderRepository Order { get; }

        void Save();

        ITenantRepository tenant { get; }


    }
}
