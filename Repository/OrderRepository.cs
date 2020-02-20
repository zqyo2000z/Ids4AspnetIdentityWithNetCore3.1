﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.Manager;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
   public  class OrderRepository:RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        //public IEnumerable<Order> GetAllOrdersAsync()
        //{
        //    return FindAll().OrderBy(o => o.Id).ToList();
        //}
        public async  Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await FindAll().OrderBy(o => o.Id).ToListAsync();
        }
    }
}
