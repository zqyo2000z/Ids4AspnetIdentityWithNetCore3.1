using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
  public   class SchedulerJob:IEntity
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        
        public DateTime CreateDate { get; set; }
        public string CronExpression { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public string JsonData { get; set; }
        public string Name { get; set; }
        public int State { get; set; }
        public int MerchantId { get; set; }

    }
}
