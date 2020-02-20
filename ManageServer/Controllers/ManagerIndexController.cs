﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Contracts.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageServer.Controllers
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
        public async Task<IActionResult> Get()
        {
            try
            {
                var orders =await _repository.Order.GetAllOrdersAsync();

                _logger.LogInfo($"Returned all orders from database.");

                return Ok(orders);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllOrdersAsync action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/Index/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
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
