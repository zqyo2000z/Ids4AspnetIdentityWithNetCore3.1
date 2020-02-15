using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class MerchantProduct:IEntity
    {
        public int Id { get; set; }

        public bool State { get; set; }
        public int MerchantId { get; set; }

        public int ProductId { get; set; }
    }
}
