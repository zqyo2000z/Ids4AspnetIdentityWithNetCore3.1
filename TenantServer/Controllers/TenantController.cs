using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;


namespace TenantServer.Controllers
{
    [Route("api/Tenant")]
    [ApiController]
    public class TenantController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        public TenantController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }


        [Route("GetTenantList")]
        [HttpGet]
        public async Task<IActionResult> GetTenantList(int settlementType, string account, string nicKname, string qqNumber, int state)
        {
            try
            {
                var tenant = _repository.tenant.GetTenantList(settlementType, account, nicKname, qqNumber, state);
                return Ok(tenant);
            }
            catch(Exception ex)
            {
                _logger.LogError("TenantController下GetTenantList函数出现代码错误：" + ex.ToString());
                return StatusCode(500, "代码错误");
            }
            
        }
    }
}
