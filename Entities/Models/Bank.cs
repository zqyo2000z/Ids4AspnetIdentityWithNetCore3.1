using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public class Bank:IEntity
    {
        public int Id { get; set; }
        public bool Activated { get; set; }

        public decimal AllDeposit { get; set; }

        public decimal AllPay { get; set; }

        public string BankBranch { get; set; }

        public string  BankMark { get; set; }

        public string  BankName { get; set; }

        public string  BankNumber { get; set; }

        public bool BankType { get; set; }

        public decimal OverMoney { get; set; }

        public string  RealName { get; set; }

        public bool State { get; set; }

        public int Version { get; set; }

        public int MerchantId { get; set; }
    }
}
