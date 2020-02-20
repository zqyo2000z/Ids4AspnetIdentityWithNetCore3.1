using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
   public  class Partition:IEntity
    {
        public int Id { get; set; }
        
        public DateTime ChangeDate { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public string DataFormat { get; set; }
        public string DbInfo { get; set; }
        public bool IsChangeInTime { get; set; }
        public string Name { get; set; }
        public string Notice { get; set; }
        public bool NoticeState { get; set; }
        public string ScriptPath { get; set; }
        public string ServerIp { get; set; }
        public string ServerPort { get; set; }
        public int Sort { get; set; }
        public bool State { get; set; }
        public string SuccessMark { get; set; }
        public int Type { get; set; }
        
        public DateTime UseDate { get; set; }
        public string UseName { get; set; }
        public string Uuid { get; set; }
        public string WebUrl { get; set; }
        public bool YbEgg { get; set; }
        public int MerchantId { get; set; }
        public int TemplateId { get; set; }
    }
}
