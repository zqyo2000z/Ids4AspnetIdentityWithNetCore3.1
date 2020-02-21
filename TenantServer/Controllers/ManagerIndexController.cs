using System;
using System.Threading.Tasks;
using Contracts;
using Contracts.Manager;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TenantServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerIndexController : ControllerBase
    {

        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public ManagerIndexController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }
        /// <summary>
        /// 订单测试
        /// </summary>
        /// <remarks>订单测试看看是否全部有效</remarks>
        /// <returns></returns>
        // GET: api/Index
        [HttpGet]
        public async  Task<IActionResult> Get()
        {
            try
            {
                var orders =await _repository.Order.GetOrdersAsync();

                _logger.LogInfo($"Returned all orders from database.");

                return Ok(orders);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetOrdersAsync action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        /// <summary>
        /// 分页查询测试
        /// </summary>
        /// <param name="orderParameters"></param>
        /// <returns></returns>
        // GET: api/Index
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get([FromQuery]OrderParameters orderParameters)
        {
            var orders =await _repository.Order.GetOrdersAsync(orderParameters);
            var metadata = new
            {
                orders.TotalCount,
                orders.PageSize,
                orders.CurrentPage,
                orders.TotalPages,
                orders.HasNext,
                orders.HasPrevious

            };
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
            _logger.LogInfo($"Returned {orders.TotalCount} orders from database.");

            return Ok(orders);
        }

        // POST: api/Index
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Index/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
