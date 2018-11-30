using Caty.Spider.Model;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caty.Spider.MainForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var ctx = new BookContext())
            //{

            //    var o = new Book();
            //    o.BookName = "测试";
            //    ctx.Books.Add(o);
            //    ctx.SaveChanges();
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmKindleSpider());
        }
    }
}
