using Caty.Spider.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caty.Spider.Model
{
    public class BookContextCore:DbContext
    {
        public IConfiguration Configuration { get; }
        public BookContextCore() : base() { }
        public BookContextCore(DbContextOptions options) : base(options) { }
        //public BookContext() :base("Data Source=.;Database=KindleDb;UID=sa;PWD=123;") { }
        public DbSet<Book> Books { get; set; }

        public DbSet<SpiderArgs> SpiderArgs { get; set; }
    }
}
