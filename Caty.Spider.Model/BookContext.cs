using Caty.Spider.Utilities.Code;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;

namespace Caty.Spider.Model
{
    public class BookContext:DbContext
    {
        public BookContext() : base(ConnectionStrings.GetConnectionValue("KindleDb")) { }
        //public BookContext() :base("Data Source=.;Database=KindleDb;UID=sa;PWD=123;") { }

        public DbSet<Book> Books { get; set; }

        public DbSet<SpiderArgs> SpiderArgs { get; set; }
    }
}