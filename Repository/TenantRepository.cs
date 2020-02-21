using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.Models;
using System.Threading.Tasks;

namespace Repository
{
    public class TenantRepository: ITenantRepository
    {

        private readonly RepositoryContext _repositoryContext;
        public TenantRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public async Task<IEnumerable<Merchant>> GetTenantList(int settlementType, string account, string nicKname, string qqNumber, int state)
        {
            using (var result = _repositoryContext)
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
                if (!string.IsNullOrEmpty(nicKname))
                {
                    iqm = iqm.Where(items => items.Nickname == nicKname);
                }
                if (!string.IsNullOrEmpty(qqNumber))
                {
                    iqm = iqm.Where(items => items.QqNumber == qqNumber);
                }
                if(state>0)
                {
                    iqm = iqm.Where(items => items.State == state);
                }   
                return iqm.ToList();
            }
            
          


        }
    }
}
