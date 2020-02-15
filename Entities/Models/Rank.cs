using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class Rank:IEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsAgency { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public int MerchantId { get; set; }
    }
}
