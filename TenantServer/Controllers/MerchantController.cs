using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Contracts.Manager;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Common;
using Contracts.Common;

namespace TenantServer.Controllers
{
    [Route("api/Merchant")]
    [ApiController]
    public class MerchantController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        public MerchantController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }


        [Route("GetTenantList")]
        [HttpGet]
        public async Task<IActionResult> GetTenantList(int settlementType, string account, string nickname, string qqNumber, int state)
        {
           
                account=SecurityUtility.FilterString(account);
                nickname=SecurityUtility.FilterString(nickname);
                qqNumber=SecurityUtility.FilterString(qqNumber);
                var tenant =await _repository.Merchant.GetTenantList(settlementType, account, nickname, qqNumber, state);
                return Ok(tenant);
            
           
            
        }
    }
}
