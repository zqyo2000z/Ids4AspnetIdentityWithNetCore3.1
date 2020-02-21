using System.IO;
using Common.LoggerService;
using Common.RedisHelper;
using Contracts;
using Contracts.Common;
using Contracts.Manager;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Repository;

namespace ManageServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.WithOrigins("http://localhost:5003", "https://localhost:5001")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .WithExposedHeaders(new string[] { "X-Pagination" }));
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
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "群鹰多渠道兑换系统", Version = "v1" });
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
                var commentsFileName = "ManageServer.xml";
                var xmlPath = Path.Combine(basePath, commentsFileName);
                c.IncludeXmlComments(xmlPath);

                c.DocInclusionPredicate((docName, description) => true);
            });
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
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
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
