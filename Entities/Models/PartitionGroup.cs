using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class PartitionGroup:IEntity
    {
        public int Id { get; set; }

        public int GroupId { get; set; }
        public int PartitionId { get; set; }
    }
}
