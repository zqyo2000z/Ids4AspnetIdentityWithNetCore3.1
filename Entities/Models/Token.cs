using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class Token:IEntity
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string TokenId { get; set; }

    }
}
