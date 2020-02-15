using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public  class PayForAnother:IEntity
    {
        public int Id { get; set; }

        public string AccountName { get; set; }

        public string AppSecret { get; set; }
        public string Email { get; set; }
        public string Mark { get; set; }
        public string MarkName { get; set; }
        public string Partner { get; set; }
        public string PublicKey { get; set; }
        public string RedirectUrl { get; set; }
        public string Remark { get; set; }
        public string ReqUrl { get; set; }
        public string SecurityKey { get; set; }
    }
}
