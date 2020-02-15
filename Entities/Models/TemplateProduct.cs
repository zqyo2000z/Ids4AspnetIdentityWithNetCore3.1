using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public  class TemplateProduct:IEntity
    {
        public int Id { get; set; }

        public string AmountRate { get; set; }
        public int Rate { get; set; }
        public int ProductId { get; set; }
        public int TemplateId { get; set; }

    }
}
