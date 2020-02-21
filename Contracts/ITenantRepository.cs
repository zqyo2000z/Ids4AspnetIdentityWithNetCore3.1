using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITenantRepository
    {
      Task<IEnumerable<Merchant>> GetTenantList(int settlementType,string account,string nicKname,string qqNumber,int state);
    }
}
