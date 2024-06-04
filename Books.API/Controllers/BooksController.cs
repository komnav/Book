using BusinessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Books.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;


        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Book book)
        {
            _bookRepository.Create(book);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var getBooks = _bookRepository.GetAll();
            return Ok(getBooks);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_bookRepository.GetById(id));
        }
       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookRepository.Delete(id);
            return Ok();
        }
       
        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Book book, int id)
        {
            book.Id = id;
            _bookRepository.Update(id, book);
            return Ok();
        }
    }
}
