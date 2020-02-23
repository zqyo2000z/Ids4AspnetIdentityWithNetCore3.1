namespace Common.MailKit
{
    #region 邮件服务配置
    /// <summary>
    /// 邮件服务配置
    /// </summary>
    public class MailKitConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSsl { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string Password { get; set; }
    }
    #endregion
}
