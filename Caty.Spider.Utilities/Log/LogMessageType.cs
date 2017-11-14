using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caty.Spider.Utilities.Log
{
    /// <summary>
    /// 日志类型
    /// </summary>
    public enum LogMessageType
    {
        /// <summary>
        /// 调试
        /// </summary>
        Debug,
        /// <summary>
        /// 信息
        /// </summary>
        Info,
        /// <summary>
        /// 警告
        /// </summary>
        Warn,
        /// <summary>
        /// 错误
        /// </summary>
        Error,
        /// <summary>
        /// 致命错误
        /// </summary>
        Fatal
    }
}
