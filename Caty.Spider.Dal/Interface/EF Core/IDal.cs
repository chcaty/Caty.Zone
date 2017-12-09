using Caty.Spider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caty.Spider.Dal.Interface.EF_Core
{
    public partial interface IBookDal : IBaseDal<Book>
    {
    }
    public partial interface ISipderArgsDal : IBaseDal<SpiderArgs>
    {
    }
}
