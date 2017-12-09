using Caty.Spider.Dal.Interface.EF_Core;
using Caty.Spider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caty.Spider.Dal.Implements.EF_Core
{
    public partial class BookDal : BaseDal<Book>, IBookDal
    {
        public BookDal(BookContextCore dbContext) : base(dbContext)
        {
        }

    }
    public partial class SpiderArgsDal : BaseDal<SpiderArgs>, ISipderArgsDal
    {
        public SpiderArgsDal(BookContextCore dbContext) : base(dbContext)
        {
        }
    }
}
