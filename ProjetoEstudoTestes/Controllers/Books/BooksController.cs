using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoEstudoTestes.Controllers.Books
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksController()
        {
            
        }

        [HttpGet]
        public async Task<IResult> ListBooks()
        {

        }
    }
}
