using Caty.Spider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caty.Spider.Dal.Interface
{
    public partial interface IBookDal : IBaseDal<Book>
    {
        bool IsExist(Book book);
    }

    public partial interface ISpiderArgsDal : IBaseDal<SpiderArgs>
    {

    }
}
