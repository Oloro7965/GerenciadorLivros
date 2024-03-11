using GerenciadorLivros.application.InputModel;
using GerenciadorLivros.application.Services.interfaces;
using GerenciadorLivros.Domain.Entitites;
using GerenciadorLivros.intraestructure.Persistance;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorLivros.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get(string query = "")
        {
            var books=_bookService.Get(query);
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var book= _bookService.GetById(id);
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post( NewBookInputModel createBookModel)
        {
            var bookId=_bookService.Create(createBookModel);
            return CreatedAtAction(nameof(GetById), new { id = bookId }, createBookModel);
        }

        [HttpPost("{id}/Avaliations")]
        public IActionResult CreateAvaliation(Guid id,NewAvaliationInputModel AvaliationInputModel)
        {
            var Avaliation = _bookService.CreateAvaliation(id,AvaliationInputModel); 
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id,BookUpdateInputModel updateBookModel)
        {
            //var book=_bookService.GetById(id);
            //book.Upda
            //_bookService.Update(BookUpdateInputModel);
            _bookService.Update(updateBookModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            _bookService.Delete(id);
            return NoContent();
        }
    }
}
