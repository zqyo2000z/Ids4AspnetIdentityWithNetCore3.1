using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public  class Settlement:IEntity
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }
        public DateTime ApplyDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public int State { get; set; }
        public int Type { get; set; }
        public int Version { get; set; }
        public int BankId { get; set; }
        public int MerchantId { get; set; }
        public int SettlementReplyId { get; set; }


    }
}
