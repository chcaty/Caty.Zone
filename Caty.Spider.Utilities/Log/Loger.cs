using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caty.Spider.Utilities
{
    /// <summary>
    /// 日志器
    /// </summary>
    public static class Loger
    {
        private static ILoger loger;
        public static ILoger Instance
        {
            get
            {
                if (loger == null)
                {
                    try
                    {
                        loger = new Log4netLoger();
                    }
                    catch (Exception)
                    {
                        throw new Exception("Log4Net配置文件丢失或配置Log4Net出现错误。");
                    }
                }
                return loger;
            }
        }
    }
}
