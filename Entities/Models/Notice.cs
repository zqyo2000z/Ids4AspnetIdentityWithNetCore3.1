using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
 public    class Notice:IEntity
    {
        public int Id { get; set; }

        public string Content { get; set; }
        
        public DateTime Date { get; set; } = DateTime.Now;
        public string Publisher { get; set; }
        
        public bool State { get; set; }

        public string Title { get; set; }

    }
}
