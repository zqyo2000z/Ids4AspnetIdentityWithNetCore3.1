using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Manager;

namespace Contracts
{
   public  interface  IRepositoryWrapper
    {
        IOrderRepository Order { get; }

        void Save();
    }
}
