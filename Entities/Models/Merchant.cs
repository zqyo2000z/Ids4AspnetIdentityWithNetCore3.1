using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Entities.Models
{
    public class Merchant : IEntity
    {
        public int Id { get; set; }

        public string Account { get; set; }
        public decimal Fee { get; set; }
        
        public DateTime FinalDate { get; set; }
        public bool IsIps { get; set; }
        public bool IsLogger { get; set; }
        public DateTime JoinDate { get; set; }
        public bool LeaveState { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneState { get; set; }
        public string QqNumber { get; set; }
        public string SecretKey { get; set; }
        public string ServicePhone { get; set; }
        public string ServiceQq { get; set; }
        public bool ServiceState { get; set; }
        public int SettlementType { get; set; }
        public int State { get; set; }
        public bool Type { get; set; }
        public string Uuid { get; set; }
        public int ParentId { get; set; }
        public int RankId { get; set; }
    }
}
