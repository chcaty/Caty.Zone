using Caty.Spider.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Caty.Spider.Dal.Implements
{
    public class DbContextFactory
    {
        public static DbContext CreateContext()
        {
            DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new BookContext();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }
    }
}
