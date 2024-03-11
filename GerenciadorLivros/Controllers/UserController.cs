using GerenciadorLivros.application.InputModel;
using GerenciadorLivros.application.Services.implementations;
using GerenciadorLivros.application.Services.interfaces;
using GerenciadorLivros.application.ViewModel;
using GerenciadorLivros.Domain.Entitites;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorLivros.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var users=_userService.Get(query);
            return Ok(users);
        }
        [HttpGet("id")]
        public IActionResult GetById(Guid id) {

            var user=_userService.GetById(id);
            return Ok(user);
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewUserInputModel NewUserInput)
        {
            var id=_userService.Create(NewUserInput);
            return CreatedAtAction(nameof(GetById), new {id=id},NewUserInput);
        }
        [HttpDelete("id")]
        public IActionResult DeleteById(Guid id)
        {
            _userService.Delete(id);
            return NoContent();
        }
    }
}
