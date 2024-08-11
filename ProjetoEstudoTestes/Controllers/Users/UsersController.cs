using Microsoft.AspNetCore.Mvc;
using ProjetoEstudoTestes.Business.UserBusiness;
using ProjetoEstudoTestes.Domain.Requests;

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

        [HttpPost]
        public async Task<IResult> CreateUser([FromBody] UserCreateRequest userRequest)
        {
            return await _usersBusiness.CreateUserAsync(userRequest);
        }
    }
}
