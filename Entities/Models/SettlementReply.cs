using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
  public   class SettlementReply:IEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }
        
        public DateTime ReplyDate { get; set; }
        public string SerialNumber { get; set; }
        public bool State { get; set; }
        public int UserId { get; set; }

    }
}
