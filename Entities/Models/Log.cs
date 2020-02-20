using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    /// <summary>
    /// 日志
    /// </summary>
  public   class Log:IEntity
    {
        public int Id { get; set; }

        
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public string Ip { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }
        public int UserId { get; set; }


    }
}
