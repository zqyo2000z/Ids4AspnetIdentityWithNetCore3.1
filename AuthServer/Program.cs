using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Ids4WithAspNetIdentity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //  CreateHostBuilder(args).Build().Run();

            var host = CreateWebHostBuilder(args).Build();
            var config = host.Services.GetRequiredService<IConfiguration>();
            var connectionString = config.GetConnectionString("DefaultConnection");
            SeedData.EnsureSeedData(connectionString);
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        }
    }
}
