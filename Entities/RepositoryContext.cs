using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
  public  class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<GalleryRate> GalleryRates { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<LoginRecord> LoginRecords { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<MerchantLog> MerchantLogs { get; set; }
        public DbSet<MerchantProduct> MerchantProducts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Partition> Partitions { get; set; }
        public DbSet<PartitionGroup> PartitionGroups { get; set; }
        public DbSet<PayForAnother> PayForAnothers { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<RankRate> RankRates { get; set; }
        public DbSet<ReissueRecord> ReissueRecords { get; set; }
        public DbSet<SchedulerJob> SchedulerJobs { get; set; }
        public DbSet<Settlement> Settlements { get; set; }
        public DbSet<SettlementReply> SettlementReplies { get; set; }
        public DbSet<SystemSet> SystemSets { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateProduct> TemplateProducts { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<WeixinInfo> WeixinInfos { get; set; }
       
    }
}
