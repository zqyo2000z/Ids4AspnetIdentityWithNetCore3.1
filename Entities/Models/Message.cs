using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
  public   class Message:IEntity
    {
        public int Id { get; set; }

        public string Account { get; set; }
        public string Content { get; set; }
        
        public DateTime LeaveDate { get; set; }
        public string PartitionName { get; set; }
        public string Phone { get; set; }
        public string Qq { get; set; }
        public bool State { get; set; }
        public int MerchantId { get; set; }
    }
}
