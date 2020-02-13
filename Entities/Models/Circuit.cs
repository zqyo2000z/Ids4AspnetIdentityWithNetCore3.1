using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    /// <summary>
    /// 线路
    /// </summary>
   public  class Circuit:IEntity
    {
        public int Id { get; set; }

        public string DomainName { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public int Port { get; set; }
        public int Type { get; set; }
        public bool State { get; set; }

    }
}
