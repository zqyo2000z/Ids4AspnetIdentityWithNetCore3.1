using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
  public   class LoginRecord:IEntity
    {
        public int Id { get; set; }

        public int Count { get; set; }
        
        public DateTime LoginTime { get; set; }

        public string Ip { get; set; }

        public int MerchantId { get; set; }

        public int SelfCount { get; set; }
        
        public DateTime VTime { get; set; }
    }
}
