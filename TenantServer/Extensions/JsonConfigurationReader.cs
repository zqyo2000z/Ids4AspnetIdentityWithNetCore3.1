using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace TenantServer.Extensions
{
    public class JsonConfigurationReader
    {
        #region 读取配置文件下的对象
        /// <summary>
        /// 读取配置文件下的对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">配置key</param>
        /// <param name="jsonfilename">配置文件名称</param>
        /// <returns></returns>
        public static T GetAppSettings<T>(string key, string jsonfilename) where T : class, new()
        {
            var baseDir = Directory.GetCurrentDirectory();
            var config = new ConfigurationBuilder().SetBasePath(baseDir).AddJsonFile(jsonfilename).Build();
            var instance = new ServiceCollection().AddOptions().Configure<T>(config.GetSection(key)).BuildServiceProvider().GetService<IOptions<T>>().Value;
            return instance;
        }
        #endregion
    }
}
