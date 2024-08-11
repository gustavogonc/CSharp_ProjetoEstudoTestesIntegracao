using Microsoft.AspNetCore.Mvc;
using ProjetoEstudoTestes.Business.UserBusiness;

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
    }
}
