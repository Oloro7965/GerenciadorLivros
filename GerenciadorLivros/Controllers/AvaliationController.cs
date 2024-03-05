using GerenciadorLivros.application.InputModel;
using GerenciadorLivros.Domain.Entitites;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorLivros.Controllers
{
    [Route("api/avaliations")]
    public class AvaliationController : Controller
    {
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetById(Guid id)
        {
            return Ok(id);
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewBookInputModel createBookModel)
        {
            var book = new Book(createBookModel.Title, createBookModel.Description, createBookModel.ISBN, createBookModel.Autor, createBookModel.Editor, createBookModel.PublishedYear, createBookModel.pagesQuantity);
            return CreatedAtAction(nameof(GetById), new { id = book.Id }, createBookModel);
        }
        [HttpPut("id")]
        public IActionResult Put(Guid id, [FromBody] BookUpdateInputModel updateBookModel)
        {
            return NoContent();
        }
    }
}
