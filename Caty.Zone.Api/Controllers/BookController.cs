using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Caty.Spider.Model;
using Caty.Spider.Dal.Implements.EF_Core;
using Caty.Spider.Dal.Interface.EF_Core;

namespace Caty.Zone.Api.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private IBookDal _bookDal;

        public BookController(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Book> GetAll()
        {
            return _bookDal.LoadEntities(b => true);
        }

        [HttpGet("{id}",Name ="Getbook")]
        public IActionResult GetById(int id)
        {
            var book = _bookDal.LoadEntities(b => b.BookId == id).FirstOrDefault();
            if(book == null)
            {
                return NotFound();
            }
            return new ObjectResult(book);
        }
    }
}