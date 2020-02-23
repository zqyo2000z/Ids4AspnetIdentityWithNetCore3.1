using System.Net;

namespace Common
{
    public class IpUtility
    {
        /// <summary>
        /// 根据IP 获取物理地址
        /// </summary>
        /// <param name="strIp"></param>
        /// <returns>**省**市</returns>
        public static string GetCityName(string strIp)
        {
            //var strUrl = "http://pv.sohu.com/cityjson/" + strIp;
            //var myWebClient = new WebClient
            //{
            //    Credentials = CredentialCache.DefaultCredentials //获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            //};
            //try
            //{
            //    var pageData = myWebClient.DownloadData(strUrl); //从指定网站下载数据
            //    var stt = Encoding.GetEncoding(936).GetString(pageData).Replace("var returnCitySN = ","").Replace( ";","").Trim();
            //    var dic = JsonConverter.FromJson<Dictionary<string, string>>(stt);
            //    var city = dic["cname"];
            //    return city;
            //}
            //catch 
            //{
            //    return null;
            //}
            var strUrl = "https://www.36ip.cn/?ip="+strIp;
            var myWebClient = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials //获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            };
            try
            {
                var pageData = myWebClient.DownloadString(strUrl); //从指定网站下载数据
                return pageData;
                //var stt = Encoding.GetEncoding(936).GetString(pageData).Replace("var returnCitySN = ", "").Replace(";", "").Trim();
                //var dic = JsonConverter.FromJson<Dictionary<string, string>>(stt);
                //var city = dic["cname"];
                //return city;
            }
            catch
            {
                return null;
            }

        }




    }
}
