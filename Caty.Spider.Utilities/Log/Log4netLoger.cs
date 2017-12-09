using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caty.Spider.Utilities
{ 
    public class Log4netLoger : ILoger
    {
        private static ILog loger = null;
        public Log4netLoger()
        {
            try
            {
                if (loger == null)
                {
                    try
                    {
                        //string logerName = System.Configuration.ConfigurationManager.AppSettings["NiMisLog"];
                        loger = LogManager.GetLogger("Spider");
                    }
                    catch
                    {
                        loger = LogManager.GetLogger("Spider");
                    }
                }
            }
            catch
            {
                loger = LogManager.GetLogger("Spider");
            }
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        public void Write(string message)
        {
            DoLog(message, LogMessageType.Info, null, Type.GetType("System.Object"));
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        public void Write(string message, LogMessageType messageType)
        {
            DoLog(message, messageType, null, Type.GetType("System.Object"));
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="type"></param>
        public void Write(string message, LogMessageType messageType, Type type)
        {
            DoLog(message, messageType, null, type);
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="ex">错误</param>
        public void Write(string message, LogMessageType messageType, Exception ex)
        {
            DoLog(message, messageType, ex, Type.GetType("System.Object"));
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="ex">错误</param>
        /// <param name="type"></param>
        public void Write(string message, LogMessageType messageType, Exception ex, Type type)
        {
            DoLog(message, messageType, ex, type);
        }

        public void Write<T>(T entity, LogMessageType messageType)
        {
            Write(entity, messageType, null, null);
        }

        /// <summary>
        /// 将日志写入数据库中，主要是操作日志
        /// </summary>
        /// <param name="entity">数据表</param>
        /// <param name="messageType"></param>
        /// <param name="ex"></param>
        /// <param name="type"></param>
        public void Write<T>(T entity, LogMessageType messageType, Exception ex, Type type)
        {
            //if (dt == null || dt.Rows.Count < 1)
            //    return;
            //int rowCount = dt.Rows.Count;
            //int columnCount = dt.Columns.Count;
            //string message = string.Empty;
            //StringBuilder build = new StringBuilder();
            //DataRow dr = null;

            //build.Append("\r\n");
            //for (int j = 0; j < columnCount; j++)
            //{
            //    string Field = dt.Columns[j].ColumnName;
            //    build.Append(Field + "\t");
            //}
            //build.Append("\r\n");

            //for (int i = 0; i < rowCount; i++)
            //{
            //    dr = dt.Rows[i]; for (int j = 0; j < columnCount; j++)
            //    {
            //        string Value = dt.Rows[i][j].ToString();
            //        build.Append(Value + "\t");
            //    }
            //    build.Append("\r\n");
            //}
            //message = build.ToString();


            //if (type == null)
            //{
            //    type = Type.GetType("System.Object");
            //}
            //DoLog(message, messageType, ex, Type.GetType("System.Object"));
        }

        /// <summary>
        /// 断言
        /// </summary>
        /// <param name="condition">条件</param>
        /// <param name="message">日志信息</param>
        public void Assert(bool condition, string message)
        {
            Assert(condition, message, Type.GetType("System.Object"));
        }

        /// <summary>
        /// 断言
        /// </summary>
        /// <param name="condition">条件</param>
        /// <param name="message">日志信息</param>
        /// <param name="type">日志类型</param>
        public void Assert(bool condition, string message, Type type)
        {
            if (condition == false)
                Write(message, LogMessageType.Info);
        }

        /// <summary>
        /// 保存日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="ex">错误</param>
        /// <param name="type">日志类型</param>
        private void DoLog(string message, LogMessageType messageType, Exception ex, Type type)
        {
            switch (messageType)
            {
                case LogMessageType.Debug:
                    loger.Debug(message, ex);
                    break;
                case LogMessageType.Info:
                    loger.Info(message, ex);
                    break;
                case LogMessageType.Warn:
                    loger.Warn(message, ex);
                    break;
                case LogMessageType.Error:
                    loger.Error(message, ex);
                    break;
                case LogMessageType.Fatal:
                    loger.Fatal(message, ex);
                    break;
            }
        }
    }
}
