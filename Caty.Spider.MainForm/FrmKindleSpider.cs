using AngleSharp.Dom;
using AngleSharp.Parser.Html;
using Caty.Spider.Crawler;
using Caty.Spider.Model;
using Caty.Spider.Utilities.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caty.Spider.MainForm
{
    public partial class FrmKindleSpider : Form
    {
        static HtmlParser htmlParser = new HtmlParser();
        static List<Book> bookList = new List<Book>();
        static List<string> pageList = new List<string>();
        int count = 0;
        Task spiderTask;
        public FrmKindleSpider()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer1 = new System.Timers.Timer();

        private void btnStart_Click(object sender, EventArgs e)
        {
            spiderTask = new Task(KindleCrawler);
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.AutoReset = true;
            spiderTask.Start();
            //new Thread((ThreadStart)(delegate ()
            //{
            //    KindleCrawler();
            //})).Start();
        }

        public void KindleCrawler()
        {
            var Url = "http://mebook.cc/";
            var kindleCrawler = new SimpleCrawler();
            kindleCrawler.OnStart += (s, e) =>
             {
                 Console.WriteLine("爬虫开始抓取地址:" + e.Uri.ToString());
                 SetMessage("爬虫开始抓取地址:" + e.Uri.ToString());
             };
            kindleCrawler.OnError += (s, e) =>
           {
               Console.WriteLine("爬虫抓取出现错误:" + e.Uri.ToString() + "，异常消息：" + e.Exception.Message);
               SetMessage("爬虫抓取出现错误: " + e.Uri.ToString() + "，异常消息：" + e.Exception.Message + "时间:" + DateTime.Now.ToString());
           };
            kindleCrawler.OnCompleted += (s, e) =>
            {
                var dom = htmlParser.Parse(e.PageSource);
                var link = dom.QuerySelectorAll("div.pagenavi");
                var temp = GetPageList(link);
                foreach (var t in temp)
                {
                    BookCrawler(t);
                    foreach (var b in bookList)
                    {
                        string url = b.BookLink;
                        BookDetailCrawler(b);
                    }
                    foreach (var b in bookList)
                    {
                        string url = b.DownloadLink;
                        if (!String.IsNullOrEmpty(url))
                        {
                            BookDownloadCrawler(b);
                        }
                    }
                    bookList.Clear();
                }
                Console.WriteLine("爬虫抓取任务完成！合计 " + link.Length + " 个页面。");
                SetMessage("爬虫抓取任务完成！合计 " + link.Length + " 个页面。");
                Console.WriteLine("爬虫抓取任务完成！合计 " + count + " 个书籍。");
                SetMessage("爬虫抓取任务完成！合计 " + count + " 个书籍。");
                Console.WriteLine("耗时：" + e.Milliseconds + "毫秒");
                SetMessage("耗时：" + e.Milliseconds + "毫秒");
                Console.WriteLine("线程：" + e.ThreadId);
                SetMessage("线程：" + e.ThreadId);
                Console.WriteLine("地址：" + e.Uri.ToString());
                SetMessage("地址：" + e.Uri.ToString());
                Console.WriteLine("===============================================");
                SetMessage("===============================================");
            };
            kindleCrawler.Start(new Uri(Url)).Wait();//没被封锁就别使用代理：60.221.50.118:8090
        }

        public List<string> GetPageList(IHtmlCollection<IElement> htmlCollection)
        {
            List<string> pagelist = new List<string>();
            //string Url = "";
            if (htmlCollection != null)
            {
                foreach (var divInfo in htmlCollection)
                {
                    var bb = divInfo.QuerySelectorAll("a").Where(i => i.GetAttribute("title").Contains("最末页")).ToList().Last();
                    var page = bb.GetAttribute("href");
                    string[] pagestr = page.Split('/');
                    string pageuri = "";
                    for (int i = 0; i < pagestr.Length - 1; i++)
                    {
                        pageuri = pageuri + pagestr[i] + "/";
                    }
                    int pagecount = Convert.ToInt32(pagestr[pagestr.Length - 1]);
                    for (int i = 1; i <= pagecount; i++)
                    {
                        pagelist.Add(pageuri + i);
                    }
                }
            }
            return pagelist;
        }

        public void BookCrawler(string url)
        {
            var Url = url;
            //var Url = "http://mebook.cc/page/2";
            var bookCrawler = new SimpleCrawler();
            bookCrawler.OnStart += (s, e) =>
            {
                Console.WriteLine("爬虫开始抓取地址：" + e.Uri.ToString());
                SetMessage("爬虫开始抓取地址:" + e.Uri.ToString());
            };
            bookCrawler.OnError += (s, e) =>
            {
                Console.WriteLine("爬虫抓取出现错误：" + e.Uri.ToString() + "，异常消息：" + e.Exception.Message);
                SetMessage("爬虫抓取出现错误: " + e.Uri.ToString() + "，异常消息：" + e.Exception.Message + "时间:" + DateTime.Now.ToString());
            };
            bookCrawler.OnCompleted += (s, e) =>
            {
                //使用正则表达式清洗网页源代码中的数据
                var bookdom = htmlParser.Parse(e.PageSource);
                var bookinfo = bookdom.QuerySelectorAll("ul.list li");
                foreach (var Info in bookinfo)
                {
                    Info.QuerySelectorAll("h2 a").ToList().ForEach(
                    a =>
                    {
                        var onlineURL = a.GetAttribute("href");
                        var title = a.GetAttribute("title");
                        bookList.Add(new Book() { BookLink = onlineURL, BookName = title });
                    });
                }
                count += bookList.Count;
                Console.WriteLine("书籍链接抓取任务完成！合计 " + bookList.Count + " 本书籍。");
                SetMessage("书籍链接抓取任务完成！合计 " + bookList.Count + " 本书籍。");
                Console.WriteLine("耗时：" + e.Milliseconds + "毫秒");
                SetMessage("耗时：" + e.Milliseconds + "毫秒");
                Console.WriteLine("线程：" + e.ThreadId);
                SetMessage("线程：" + e.ThreadId);
                Console.WriteLine("地址：" + e.Uri.ToString());
                SetMessage("地址：" + e.Uri.ToString());
                Console.WriteLine("===============================================");
                SetMessage("===============================================");
                Thread.Sleep(100);
            };
            bookCrawler.Start(new Uri(Url)).Wait();//没被封锁就别使用代理：60.221.50.118:8090
        }

        public void BookDetailCrawler(Book book)
        {
            var Url = book.BookLink;
            var bookdetailCrawler = new SimpleCrawler();
            bookdetailCrawler.OnStart += (s, e) =>
            {
                Console.WriteLine("爬虫开始抓取地址：" + e.Uri.ToString());
                SetMessage("爬虫开始抓取地址:" + e.Uri.ToString());
            };
            bookdetailCrawler.OnError += (s, e) =>
            {
                Console.WriteLine("爬虫抓取出现错误：" + e.Uri.ToString() + "，异常消息：" + e.Exception.Message);
                SetMessage("爬虫抓取出现错误: " + e.Uri.ToString() + "，异常消息：" + e.Exception.Message + "时间:" + DateTime.Now.ToString());
            };
            bookdetailCrawler.OnCompleted += (s, e) =>
            {
                //使用正则表达式清洗网页源代码中的数据
                var detaildom = htmlParser.Parse(e.PageSource);
                var detailinfo = detaildom.QuerySelectorAll("p.downlink strong");
                foreach (var Info in detailinfo)
                {
                    Info.QuerySelectorAll("a").ToList().ForEach(
                    a =>
                    {
                        var onlineURL = a.GetAttribute("href");
                        book.DownloadLink = onlineURL;
                        // bookList.Find(b=>b.BookLink.Equals(Url)).DownloadLink = onlineURL;
                    });
                }
                Console.WriteLine(book.BookName + "详细信息抓取任务完成！");
                SetMessage(book.BookName + "详细信息抓取任务完成！");
                Console.WriteLine("耗时：" + e.Milliseconds + "毫秒");
                SetMessage("耗时：" + e.Milliseconds + "毫秒");
                Console.WriteLine("线程：" + e.ThreadId);
                SetMessage("线程：" + e.ThreadId);
                Console.WriteLine("地址：" + e.Uri.ToString());
                SetMessage("地址：" + e.Uri.ToString());
                Console.WriteLine("===============================================");
                SetMessage("===============================================");
            };
            bookdetailCrawler.Start(new Uri(Url)).Wait();//没被封锁就别使用代理：60.221.50.118:8090
        }

        public void BookDownloadCrawler(Book book)
        {
            var Url = book.DownloadLink;
            var bookdownloadCrawler = new SimpleCrawler();
            bookdownloadCrawler.OnStart += (s, e) =>
            {
                Console.WriteLine("爬虫开始抓取地址：" + e.Uri.ToString());
                SetMessage("爬虫开始抓取地址:" + e.Uri.ToString());
            };
            bookdownloadCrawler.OnError += (s, e) =>
            {
                Console.WriteLine("爬虫抓取出现错误：" + e.Uri.ToString() + "，异常消息：" + e.Exception.Message);
                SetMessage("爬虫抓取出现错误: " + e.Uri.ToString() + "，异常消息：" + e.Exception.Message + "时间:" + DateTime.Now.ToString());
            };
            bookdownloadCrawler.OnCompleted += (s, e) =>
            {
                //使用正则表达式清洗网页源代码中的数据
                var downloaddom = htmlParser.Parse(e.PageSource);
                var downloadlinkinfo = downloaddom.QuerySelectorAll("div.list");
                foreach (var Info in downloadlinkinfo)
                {
                    List<string> linklist = new List<string>();
                    Info.QuerySelectorAll("a").ToList().ForEach(
                    a =>
                    {
                        var onlineURL = a.GetAttribute("href");
                        linklist.Add(onlineURL);
                            //book.DownloadLink = onlineURL;
                            //bookList.Find(b => b.BookLink.Equals(Url)).DownloadLink = onlineURL;
                        });
                    book.DownloadLink_BDYP = linklist[0];
                    book.DownloadLink_CDWP = linklist[1];
                    book.DownloadLink_TYYP = linklist[2];
                }
                var downloadpwdinfo = downloaddom.QuerySelectorAll("div.desc p").ToList();
                var info = downloadpwdinfo[downloadpwdinfo.Count - 3].InnerHtml;
                string[] str = info.Split('：');
                book.DownloadPsw_BDYP = str[2].Substring(0, 4);
                book.DownloadPsw_TYYP = str[3].Substring(0, 4);

                Console.WriteLine(book.BookName + "下载链接抓取任务完成！");
                SetMessage(book.BookName + "下载链接抓取任务完成！");
                Console.WriteLine("耗时：" + e.Milliseconds + "毫秒");
                SetMessage("耗时：" + e.Milliseconds + "毫秒");
                Console.WriteLine("线程：" + e.ThreadId);
                SetMessage("线程：" + e.ThreadId);
                Console.WriteLine("地址：" + e.Uri.ToString());
                SetMessage("地址：" + e.Uri.ToString());
                Console.WriteLine("===============================================");
                SetMessage("===============================================");
                Thread.Sleep(10);
            };
            bookdownloadCrawler.Start(new Uri(Url)).Wait();//没被封锁就别使用代理：60.221.50.118:8090
        }

        void SetMessage(string message)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                txtLog.Text += string.Format("[{0}]{1}\r\n", DateTime.Now, message);
            }));
            Loger.Instance.Write(message, LogMessageType.Error);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            spiderTask.Dispose();
        }

        private void FrmKindleSpider_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //得到 hour minute second 如果等于某个值就开始执行程序
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            int intSecond = e.SignalTime.Second;
            //定制时间 如 在10：30：00的时候执行某个函数
            int iHour = 00;
            int iMinute = 30;
            int iSecond = 00;
            // 设置　 每秒钟的开始执行一次  
            if (intHour == iHour && intMinute == iMinute)
            {
                //SetMessage("每秒钟的开始执行一次！");
                spiderTask.Start();
            }
            //设置时间 开始执行程序
            //if (intHour == iHour && intMinute == iMinute && intSecond == iSecond)
            //{
            //    SetMessage("定时测试~~~");
            //}
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FrmConfig frmConfig = new FrmConfig();
            frmConfig.ShowDialog();
        }
    }
}
