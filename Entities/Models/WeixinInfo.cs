using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public  class WeixinInfo:IEntity
    {
        public int Id { get; set; }
        public string AccessToken { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int ExpiresIn { get; set; }
        public string HeadImgUrl { get; set; }
        public DateTime JoinDate { get; set; }
        public int MerchantId { get; set; }
        public string Nickname { get; set; }
        public string OpenId { get; set; }
        public string Province { get; set; }
        public string RefreshToken { get; set; }
        public bool sex { get; set; }
        public string UnionId { get; set; }


    }
}
