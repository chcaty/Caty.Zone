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
        public BookContext(string connectionName = "KindleDb") : base(connectionName) { }

        public DbSet<Book> Books { get; set; }
    }
}