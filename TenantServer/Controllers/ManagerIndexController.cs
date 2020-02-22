using System;
using System.Threading.Tasks;
using Contracts;
using Contracts.Common;
using Contracts.Manager;
using Entities.DTO;
using Microsoft.AspNetCore.Http;
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
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <returns></returns>
        /// <response code="200">返回成功的示例</response>
        /// <response code="400">返回失败显示的内容</response> 

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async  Task<IActionResult> GetOrders()
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
        /// 查询分页测试
        /// </summary>
        /// <param name="orderParameters"></param>
        /// <returns></returns>
        /// <response code="200">返回成功的示例</response>
        /// <response code="400">返回失败显示的内容</response> 
        [HttpGet("GetPages")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPages([FromQuery]OrderParameters orderParameters)
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

      
    }
}
