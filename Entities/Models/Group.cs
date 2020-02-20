using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
   public class Group:IEntity
    {
        public int Id { get; set; }

        
        public DateTime CreateDate { get; set; }

        public string Name { get; set; }
        public string Uuid { get; set; }

        public int MerchantId { get; set; }
    }
}
