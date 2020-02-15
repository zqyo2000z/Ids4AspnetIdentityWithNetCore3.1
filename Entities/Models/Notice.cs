using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
 public    class Notice:IEntity
    {
        public int Id { get; set; }

        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Publisher { get; set; }
        
        public bool State { get; set; }

        public string Title { get; set; }

    }
}
