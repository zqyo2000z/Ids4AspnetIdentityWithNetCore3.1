using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class ReissueRecord:IEntity
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }
        public string PlayerName { get; set; }
        public string PlayerAccount { get; set; }
        public DateTime ReissueDate { get; set; }
        public string SerialNumber { get; set; }
        public bool Type { get; set; }
        public int MerchantId { get; set; }
        public int PartitionId { get; set; }
        public int ProductId { get; set; }
    }
}
