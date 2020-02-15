using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public  class Visit:IEntity
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public DateTime LoginTime { get; set; }
        public string Domain { get; set; }
        public string Ips { get; set; }
        public int MerchantId { get; set; }
        public int OrderCount { get; set; }
        public decimal OrderMoney { get; set; }
        public decimal Profit { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
