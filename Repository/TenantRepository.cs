using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.Models;
using System.Threading.Tasks;
using Contracts.Tenant;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class TenantRepository: ITenantRepository
    {

        private readonly RepositoryContext _repositoryContext;
        public TenantRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public async Task<IEnumerable<Merchant>> GetTenantList(int settlementType, string account, string nickname, string qqNumber, int state)
        {
           
                IQueryable<Merchant> iqm = _repositoryContext.Merchants;
                if(settlementType>0)
                {
                    iqm = iqm.Where(items => items.SettlementType == settlementType);
                }
                if (!string.IsNullOrEmpty(account))
                {
                    iqm = iqm.Where(items => items.Account == account);
                }
                if (!string.IsNullOrEmpty(nickname))
                {
                    iqm = iqm.Where(items => items.Nickname == nickname);
                }
                if (!string.IsNullOrEmpty(qqNumber))
                {
                    iqm = iqm.Where(items => items.QqNumber == qqNumber);
                }
                if(state>0)
                {
                    iqm = iqm.Where(items => items.State == state);
                }   
                return await iqm.ToListAsync();
           
            
          


        }
    }
}
