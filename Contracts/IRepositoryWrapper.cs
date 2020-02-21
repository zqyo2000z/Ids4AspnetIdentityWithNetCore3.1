using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Contracts.Manager;

namespace Contracts
{
   public  interface  IRepositoryWrapper
    {
        IOrderRepository Order { get; }

        void Save();
    }
}
