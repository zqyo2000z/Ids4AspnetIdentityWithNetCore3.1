using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class SystemSet:IEntity
    {
        public int Id { get; set; }

        public string About { get; set; }
        public string CompanyAddress { get; set; }
        public string Cq3Version { get; set; }
        public decimal DefaultFee { get; set; }
        public string FeeStandard { get; set; }
        public string GameEngine { get; set; }
        public bool IsIps { get; set; }
        public bool IsLogin { get; set; }

        public bool IsOpenTailAmount { get; set; }
        public int LoginTime { get; set; }
        public string Mark { get; set; }
        public int RegisterState { get; set; }
        public string ServicePhone { get; set; }
        public string ServiceQq { get; set; }
        public string SettlementBank { get; set; }
        public int SettlementType { get; set; }
        public decimal T0MinAmount { get; set; }
        public decimal T1MinAmount { get; set; }
        public int TailAmountRatio { get; set; }
        public int TailAmountScope { get; set; }
        public int TaskCount { get; set; }
        public bool TimedSettlement { get; set; }
        public string TyVersion { get; set; }
        public string Version { get; set; }
        public int VisitTime { get; set; }
        public string WebName { get; set; }

    }
}
