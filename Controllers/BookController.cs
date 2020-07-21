using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Book> GetBooks() 
        {
            return Ok(Book.GetBooks());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = Book.GetBooks().FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> Post(Book book) 
        {
            Book.Books.Add(book);
            return Created("", book);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Book> Delete(int id) 
        {
            var book = Book.GetBooks().FirstOrDefault(x => x.Id == id);
            if (book == null) 
            {
                return NotFound();
            }
            Book.Books.Remove(book);
            return NoContent();
        }
    }
}
