using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public   class Template:IEntity
    {
        public int Id { get; set; }
        public string BrowserCommand { get; set; }
        public bool CardState { get; set; }
        public string CurrencyName { get; set; }
        public int EquipType { get; set; }
        public string GameEngine { get; set; }
        public bool GiveState { get; set; }
        public bool GiveWay { get; set; }
        public string InfoAdditional { get; set; }
        public string InfoEquip { get; set; }
        public string InfoIncentive { get; set; }
        public string InfoIntegral { get; set; }
        public string InfoNpc { get; set; }
        public string InfoRedPacket { get; set; }
        public bool IsContains { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal MinAmount { get; set; }
        public string Name { get; set; }
        public int Ratio { get; set; }
        public string RechargeWay { get; set; }
        public bool RedPacketAdditional { get; set; }
        public bool RedPacketEquip { get; set; }
        public bool RedPacketIntegral { get; set; }
        public bool RedPacketState { get; set; }
        public string ScriptCommand { get; set; }
        public bool ShowAdditional { get; set; }
        public bool ShowEquip { get; set; }
        public bool ShowIntegral { get; set; }
        public int Type { get; set; }
        public int MerchantId { get; set; }


    }
}
