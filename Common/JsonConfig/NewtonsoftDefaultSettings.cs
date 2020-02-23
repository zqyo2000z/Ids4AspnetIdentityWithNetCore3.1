namespace Common.JsonConfig
{
    /// <summary>
    /// JSon默认配置
    /// </summary>
    public static class NewtonsoftDefaultSettings
    {
        public static void Default(Newtonsoft.Json.JsonSerializerSettings setting)
        {
            setting.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
            setting.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            setting.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;
            setting.DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include;
            setting.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            setting.ConstructorHandling = Newtonsoft.Json.ConstructorHandling.Default;
            setting.StringEscapeHandling = Newtonsoft.Json.StringEscapeHandling.Default;
            setting.FloatParseHandling = Newtonsoft.Json.FloatParseHandling.Double;
            setting.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            setting.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }

    }
}
