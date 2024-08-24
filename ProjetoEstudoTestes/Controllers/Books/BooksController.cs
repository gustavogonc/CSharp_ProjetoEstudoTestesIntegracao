using Microsoft.AspNetCore.Mvc;
using ProjetoEstudoTestes.Business.Book;

namespace ProjetoEstudoTestes.Controllers.Books
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookBusiness _bookBusiness;
        public BooksController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        [HttpGet]
        public async Task<IResult> ListBooks()
        {
            var result = _bookBusiness.ListAllBooks();
            return Results.Ok(result);
        }

        [HttpGet("{id:guid}")]
        public async Task<IResult> ListBookId(Guid id)
        {
            var result = await _bookBusiness.ListBookByIdAsync(id);
            return Results.Ok(result);
        }
    }
}
