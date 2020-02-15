using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class Order:IEntity
    {
        public int Id { get; set; }

        public decimal AgentProfit { get; set; }

        public decimal Amount { get; set; }

        public string CardNumber { get; set; }
        public string Description { get; set; }
        public decimal GiveAmount { get; set; }
        public int GroupId { get; set; }

        public decimal MerchantProfit { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public decimal PlatformProfit { get; set; }
        public string PlayerPhone { get; set; }
        public string PlayerQq { get; set; }
        public decimal RedPacketAmount { get; set; }
        public string Remarks { get; set; }
        public int State { get; set; }
        public string SupNumber { get; set; }
        public decimal TailAmount { get; set; }
        public decimal TailAmountProfit { get; set; }
        public decimal TailRate { get; set; }
        public int Version { get; set; }
        public int AgentId { get; set; }
        public int MerchantId { get; set; }
        public int PartitionId { get; set; }
        public int ProductId { get; set; }

        public int GalleryId { get; set; }
    }
}
