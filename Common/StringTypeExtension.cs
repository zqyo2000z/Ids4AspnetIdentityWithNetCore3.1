using System;
using System.Text.RegularExpressions;

namespace Common
{
    /// <summary>
    /// 字符串扩展
    /// </summary>
    public static class StringTypeExtension
    {
        #region 获取是否对应字符串类型
        /// <summary>
        /// 获取是否对应字符串类型
        /// </summary>
        /// <param name="str"></param>
        /// <param name="stringType"></param>
        /// <returns></returns>
        public static bool IsDistType(this String str,StringType stringType)
        {
            string pattern = string.Empty;
            switch (stringType)
            {
                case StringType.Integer://整数
                    pattern = @"^-?[0-9]\d*$";
                    break;
                case StringType.PositiveInteger://正整数
                    pattern = "^[0-9]*[1-9][0-9]*$";
                    break;
                case StringType.NegativeInteger://负整数
                    pattern = "^-[0-9]*[1-9][0-9]*$";
                    break;
                case StringType.Digital://数字
                    pattern = "^([+-]?)\\d*\\.?\\d+$";
                    break;
                case StringType.Phone://电话

                    //在做项目时常常用到判断电话号码的正则表达式，写了一个，可验证如下27种格式：

                    //110

                    //8888888

                    //88888888

                    //8888888-123

                    //88888888-23435

                    //0871-8888888-123

                    //023-88888888-23435

                    //86-0871-8888888-123

                    //8888888_123

                    //88888888_23435

                    //0871_8888888_123

                    //023_88888888_23435

                    //86_0871_8888888_123

                    //8888888－123

                    //88888888－23435

                    //0871－8888888－123

                    //023－88888888－23435

                    //86－0871－8888888－123

                    //8888888—123

                    //88888888—23435

                    //0871—8888888—123

                    //023—88888888—23435

                    //86—0871—8888888—123

                    //13588888888

                    //15988888888

                    //013588888888

                    //015988888888

                    //(0315)7663551
                    pattern = @"((^(\d{2,4}[-_－—]?)?\d{3,8}([-_－—]?\d{3,8})?([-_－—]?\d{1,7})?$)|(^0?1[35]\d{9}$)z)|(^(\([0-9]+\))?[0-9]{7,8}$)";
                    break;
                case StringType.Positive://正数（正整数+ 0）
                    pattern = @"^\d+$";
                    break;
                case StringType.Negative://负数（负整数+ 0）
                    pattern = @"^((-\d+)|(0+))$";
                    break;
                case StringType.Float://浮点数
                    pattern = @"^(-?\d+)(\.\d+)?$";
                    break;
                case StringType.PositiveFloat://正浮点数
                    pattern = @"^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*))$";
                    break;
                case StringType.NegativeFloat://负浮点数
                    pattern = @"^(-(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*)))$";
                    break;
                case StringType.Email://邮件                   //正确
                    pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
                    break;
                case StringType.Color://颜色
                    pattern = "^[a-fA-F0-9]{6}$";
                    break;
                case StringType.Url:
                    pattern = @"(https?|ftp|file)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]";
                    break;
                case StringType.Chinese://仅中文
                    pattern = @"[\u4e00-\u9fa5]";
                    break;
                case StringType.ACSII://仅ACSII字符
                    pattern = "^[\\x00-\\xFF]+$";
                    break;
                case StringType.PostCode://邮编
                    pattern = "^\\d{6}$";
                    break;
                case StringType.MobilePhone://手机(13号段和号段)
                    pattern = "^1[3456789][0-9]{9}$";
                    break;
                case StringType.IP://ip地址
                    pattern = @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$";
                    break;
                case StringType.NotNull://非空
                    pattern = "^\\S+$";
                    break;
                case StringType.Image://图片
                    pattern = @"(.*)\.(jpg|gif|png|bmp)$";
                    break;
                case StringType.Zip://压缩文件
                    pattern = "(.*)\\.(rar|zip|7zip|tgz)$";
                    break;
                case StringType.Date://日期
                    //这个日期正则表达式支持

                    //YYYY-MM-DD

                    //YYYY/MM/DD

                    //YYYY_MM_DD

                    //YYYY.MM.DD的形式

                    pattern = @"((^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(10|12|0?[13578])([-\/\._])(3[01]|[12][0-9]|0?[1-9])$)|(^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(11|0?[469])([-\/\._])(30|[12][0-9]|0?[1-9])$)|(^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(0?2)([-\/\._])(2[0-8]|1[0-9]|0?[1-9])$)|(^([2468][048]00)([-\/\._])(0?2)([-\/\._])(29)$)|(^([3579][26]00)([-\/\._])(0?2)([-\/\._])(29)$)|(^([1][89][0][48])([-\/\._])(0?2)([-\/\._])(29)$)|(^([2-9][0-9][0][48])([-\/\._])(0?2)([-\/\._])(29)$)|(^([1][89][2468][048])([-\/\._])(0?2)([-\/\._])(29)$)|(^([2-9][0-9][2468][048])([-\/\._])(0?2)([-\/\._])(29)$)|(^([1][89][13579][26])([-\/\._])(0?2)([-\/\._])(29)$)|(^([2-9][0-9][13579][26])([-\/\._])(0?2)([-\/\._])(29)$))";
                    break;

                case StringType.QQ://QQ号码
                    pattern = "[1-9][0-9]{4,}";
                    break;
                case StringType.UserName://用来用户注册。匹配由数字、个英文字母或者下划线组成的字符串
                    pattern = "^(?!\\d)[a-zA-Z0-9_\\u4e00-\\u9fa5]+$";
                    break;
                case StringType.Letter://字母
                    pattern = "^[A-Za-z]+$";
                    break;
                case StringType.CapitalLetter://大写字母
                    pattern = "^[A-Z]+$";
                    break;
                case StringType.LowercaseLetter://小写字母
                    pattern = "^[a-z]+$";
                    break;
                case StringType.IdCard://身份证
                    pattern = @"^[1-9]([0-9]{16}|[0-9]{13})[xX0-9]$";
                    break;
                default:
                    pattern = string.Empty;
                    break;
                case StringType.BankCarID://银行卡号
                    pattern = @"^\d{16}|\d{18}$";
                    break;
                case StringType.BankAccountName://开户名
                    pattern = @"^[\u4e00-\u9fa5]{2,6}$";
                    break;

            }
            return Regex.IsMatch(str, pattern);
        }
        #endregion
    }

    /// <summary>
    /// 字符串类型
    /// </summary>
    public enum StringType
    {
        /// <summary>
        /// 整数
        /// </summary>
        Integer,//整数 = 0,

        /// <summary>
        /// 正整数
        /// </summary>
        PositiveInteger,//正整数,

        /// <summary>
        /// 负整数
        /// </summary>
        NegativeInteger,//负整数,

        /// <summary>
        /// 数字
        /// </summary>
        Digital,//数字,

        /// <summary>
        /// 电话
        /// </summary>
        Phone,//电话,

        /// <summary>
        /// 正数
        /// </summary>
        Positive,//正数,

        /// <summary>
        /// 负数
        /// </summary>
        Negative,//负数,

        /// <summary>
        /// 浮点数
        /// </summary>
        Float,//浮点数,

        /// <summary>
        /// 正浮点数
        /// </summary>
        PositiveFloat,//正浮点数,

        /// <summary>
        /// 负浮点数
        /// </summary>
        NegativeFloat,//负浮点数,

        //浮点数2,
        //非负浮点数,
        //非正浮点数,
        /// <summary>
        /// 邮件
        /// </summary>
        Email,//邮件,

        /// <summary>
        /// 颜色
        /// </summary>
        Color,//颜色,

        /// <summary>
        /// url
        /// </summary>
        Url,//url,

        /// <summary>
        /// 中文
        /// </summary>
        Chinese,//中文,

        /// <summary>
        /// ACSII字符
        /// </summary>
        ACSII,//ACSII字符,

        /// <summary>
        /// 邮编
        /// </summary>
        PostCode,//邮编,

        /// <summary>
        /// 手机
        /// </summary>
        MobilePhone,//手机,

        /// <summary>
        /// IP地址
        /// </summary>
        IP,//IP地址,

        /// <summary>
        /// 非空
        /// </summary>
        NotNull,//非空,

        /// <summary>
        /// 图片
        /// </summary>
        Image,//图片,

        /// <summary>
        /// 压缩文件
        /// </summary>
        Zip,//压缩文件,

        /// <summary>
        /// 日期
        /// </summary>
        Date,//日期,

        /// <summary>
        /// QQ号码
        /// </summary>
        QQ,//QQ号码,

        /// <summary>
        /// 用户名
        /// </summary>
        UserName,//用户名 = 27,

        /// <summary>
        /// 字母
        /// </summary>
        Letter,//字母,

        /// <summary>
        /// 大写字母
        /// </summary>
        CapitalLetter,//大写字母,

        /// <summary>
        /// 小写字母
        /// </summary>
        LowercaseLetter,//小写字母,

        /// <summary>
        /// 身份证
        /// </summary>
        IdCard,//身份证

        /// <summary>
        ///银行卡号
        /// </summary>
        BankCarID,

        /// <summary>
        ///开户名
        /// </summary>
        BankAccountName,

    }
}
