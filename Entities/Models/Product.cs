using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class Product:IEntity
    {
        public int Id { get; set; }

        public string Mark { get; set; }
        public string MarkName { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public bool State { get; set; }
        public int Type { get; set; }
        public string TypeMark { get; set; }
        public int GalleryId { get; set; }
    }
}
