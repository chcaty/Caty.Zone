using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caty.Spider.Model
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookName { get; set; }

        public string BookLink { get; set; }

        public string DownloadLink { get; set; }

        public string DownloadLink_BDYP { get; set; }

        public string DownloadPsw_BDYP { get; set; }

        public string DownloadLink_CTWP { get; set; }

        public string DownloadPsw_CTWP { get; set; }

        public string DownloadLink_TYYP { get; set; }

        public string DownloadPsw_TYYP { get; set; }
    }
}
