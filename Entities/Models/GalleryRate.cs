using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class GalleryRate:IEntity
    {
        public int Id { get; set; }

        public decimal Rate { get; set; }
        public string RequestUrl { get; set; }
        public bool Route { get; set; }
        public int GalleryId { get; set; }
        public int ProductId { get; set; }
    }
}
