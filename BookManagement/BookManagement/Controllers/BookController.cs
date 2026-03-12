using Microsoft.AspNetCore.Mvc;
using BookManagement.Application.Services;
using BookManagement.Domain.Entities;

namespace BookManagement.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookService _service;

        public BookController(BookService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetBooks());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _service.GetBook(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Book book)
        {
            _service.AddBook(book);
            return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Book book)
        {
            if (id != book.Id) return BadRequest();
            _service.UpdateBook(book);
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteBook(id);
            return NoContent();
        }
    }
}