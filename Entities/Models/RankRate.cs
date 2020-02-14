using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public  class RankRate:IEntity
    {
        public int Id { get; set; }

        public decimal Rate { get; set; }
        public int ProductId { get; set; }
        public int RankId { get; set; }
    }
}
