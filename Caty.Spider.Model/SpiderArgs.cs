using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caty.Spider.Model
{
    public class SpiderArgs
    {
        [PrimaryKey, AutoIncrement]
        public int SpiderArgsId { get; set; }

        public int SpiderType { get; set; }

        public string Hour { get; set; }

        public string Minute { get; set; }
    }
}
