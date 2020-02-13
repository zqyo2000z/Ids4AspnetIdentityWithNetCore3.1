using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public  class Gallery:IEntity
    {
        public int Id { get; set; }

        public string Account { get; set; }
        public string AppId { get; set; }
        public string Description { get; set; }
        public bool IsRedirect { get; set; }
        public string Mark { get; set; }
        public decimal MaxAmount { get; set; }
        public string Md5Key { get; set; }
        public decimal MinAmount { get; set; }
        public string Name { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public string RiskDomain { get; set; }
        public bool RiskState { get; set; }
        public bool State { get; set; }
        public int Weight { get; set; }
     
    }
}
