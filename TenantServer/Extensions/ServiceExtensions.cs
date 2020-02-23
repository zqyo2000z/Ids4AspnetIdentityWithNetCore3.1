using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Common.LoggerService;
using Common.MailKit;
using Common.RedisHelper;
using Contracts;
using Contracts.Common;
using Contracts.Manager;
using Entities;
using Entities.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Repository;

namespace TenantServer.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// 跨越
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.WithOrigins("http://localhost:5003", "https://localhost:5001")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials().WithExposedHeaders("X-Pagination"));
            });
        }

        /// <summary>
        /// 配置Redis
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void ConfigureRedis(this IServiceCollection services, IConfiguration configuration)
        {
            //全局注入Redis
            services.AddSingleton<RedisHelper>(new RedisHelper(0,
                configuration.GetSection("RedisConnectionString").Value));
        }
        /// <summary>
        /// 配置Swagger
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "群鹰多渠道兑换系统商户后台", Version = "v1" });
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
                var commentsFileName = "TenantServer.xml";
                var xmlPath = Path.Combine(basePath, commentsFileName);
                c.IncludeXmlComments(xmlPath);
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //c.IncludeXmlComments(xmlPath);
                c.DocInclusionPredicate((docName, description) => true);
            });
        }

        /// <summary>
        /// 配置日志
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureMail(this IServiceCollection services,MailKitConfig mailKitConfig)
        {
            services.AddSingleton(typeof(MailKitManager), new MailKitManager(mailKitConfig));
        }
        public static void ConfigureSqlServerService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper,RepositoryWrapper>();
        }
    }
}
