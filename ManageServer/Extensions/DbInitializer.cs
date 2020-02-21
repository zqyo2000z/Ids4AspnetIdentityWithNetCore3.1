using System;
using System.Linq;
using Entities;
using Entities.Models;

namespace ManageServer.Extensions
{
    /// <summary>
    /// 加入种子数据
    /// </summary>
    public static class DbInitializer
    {
        public static void Initialize(RepositoryContext context)
        {
            context.Database.EnsureCreated();
            if (context.Orders.Any())
            {
                return;
            }

            var order = new Order
            {
                AgentProfit = 0.1M,
                Amount = 100,
                CardNumber = "100010",
                Description = "第一条直接插入的测试数据",
                GiveAmount = 100,
                GroupId = 10000,
                MerchantProfit = 99,
                OrderDate = DateTime.Now,
                OrderNumber = "10000",
                PayAmount = 99,
                PlatformProfit = 0.1M,
                PlayerAccount = "",
                PlayerIp = "129.125.132.11",
                PlayerPhone = "13135659335",
                PlayerQq = "7589848",
                RedPacketAmount = 10,
                Remarks = "这是一个测试，这是一个测试订单",
                State =1,
                SupNumber ="adag1323222",
                TailAmount = 100,
                TailAmountProfit = 99.2M,
                TailRate = 0.99M,
                Version = 2,
                AgentId = 332222333,
                GalleryId = 100000,
                MerchantId = 10000,
                PartitionId = 10000,
                ProductId = 10000

            };
            context.Orders.Add(order);
            context.SaveChanges();
        }
        
    }
}
