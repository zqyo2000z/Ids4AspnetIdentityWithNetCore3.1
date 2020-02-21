using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
  public   class MerchantLog:IEntity
    {
        public int Id { get; set; }
        
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public string Ip { get; set; }

        public string Message { get; set; }

        public int MerchantId { get; set; }

    }
}
