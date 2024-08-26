using Microsoft.AspNetCore.Mvc;
using ProjetoEstudoTestes.Business.UserBusiness;
using ProjetoEstudoTestes.Domain.Requests.User;

namespace ProjetoEstudoTestes.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserBusiness _usersBusiness;
        public UsersController(IUserBusiness userBusiness)
        {
            _usersBusiness = userBusiness;
        }


        [HttpGet]
        public async Task<IResult> UsersList()
        {
            return await _usersBusiness.ListUsersAsync();
        }

        [HttpGet("{id:guid}")]
        public async Task<IResult> UserWithBooks(Guid id)
        {
            return await _usersBusiness.ListBooksCreatedByUserAsync(id);
        }

        [HttpPost]
        public async Task<IResult> CreateUser([FromBody] UserCreateRequest userRequest)
        {
            return await _usersBusiness.CreateUserAsync(userRequest);
        }
    }
}
