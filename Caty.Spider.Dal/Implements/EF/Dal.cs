using Caty.Spider.Dal.Interface;
using Caty.Spider.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caty.Spider.Dal.Implements
{
    public partial class BookDal : BaseDal<Book>, IBookDal
    {
        DbContext Db = DbContextFactory.CreateContext();
        public bool IsExist(Book book)
        {
            var list = Db.Set<Book>().Where(b => b.BookName == book.BookName ).ToList();
            if(list.Count() > 0)
            {
                return true;
            }
            return false;
        }
    }

    public partial class SpiderArgsDal : BaseDal<SpiderArgs>, ISpiderArgsDal
    {

    }
}
