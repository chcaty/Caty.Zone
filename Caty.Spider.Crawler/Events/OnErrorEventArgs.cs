using System;
using System.Collections.Generic;
using System.Text;

namespace Caty.Spider.Crawler.Events
{
    /// <summary>
    /// 爬虫错误事件
    /// </summary>
    public class OnErrorEventArgs
    {
        public Uri Uri { get; set; }

        public Exception Exception { get; set; }

        public OnErrorEventArgs(Uri uri, Exception exception)
        {
            this.Uri = uri;
            this.Exception = exception;
        }
    }
}
