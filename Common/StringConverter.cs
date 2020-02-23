using System;
using System.Text.RegularExpressions;

namespace Common
{
    /// <summary>
    /// 字符串处理类
    /// </summary>
    public class StringConverter
    {
        #region 将用逗号隔开的字符串转化为单个引号组合的字符串
        /// <summary>
        /// 将用逗号隔开的字符串转化为单个引号组合的字符串，如 123，456 变成 '123','456'
        /// </summary>
        /// <returns></returns>
        public static string FormatMutString(string str)
        {
            string returnResult = string.Empty;
            string[] strs = str.Split(',');
            foreach (string st in strs)
            {
                if (st != null && st != "")
                {
                    returnResult += "'" + st + "',";
                }
            }
            int lastIndex = returnResult.LastIndexOf(',');
            returnResult = returnResult.Substring(0, lastIndex);
            strs = null;
            str = null;
            return returnResult;
        }
        /// <summary>
        /// 判断是否是数字
        /// </summary>
        /// <param name="Str"></param>
        /// <returns></returns>
        public static bool IsNum(string Str)
        {
            bool bl = false;
            string Rx = @"^[1-9]\d*$";
            if (Regex.IsMatch(Str, Rx))
            {
                bl = true;//表示输入是数字
            }
            else
            {
                bl = false;//表示输入是非数字
            }
            return bl;
        }




        #endregion

        #region 根据实际金额和手续费百分值获取到手金额和手续费
        /// <summary>
        /// 根据实际金额和手续费百分值获取到手金额和手续费
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="servicefeePercent"></param>
        /// <returns></returns>
        public static decimal getCalcPercentMoney(decimal amount, decimal servicefeePercent)
        {
            decimal servicefeePercentValue = Convert.ToDecimal(servicefeePercent / 100.00M);//手续费比例值
            decimal sxf = Convert.ToDecimal((servicefeePercentValue * amount).ToString("F2"));//手续费
            decimal sj = Convert.ToDecimal((amount - sxf).ToString("F2")); //实际金额
            return sxf;
        }
        #endregion
    }
}
