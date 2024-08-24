using ProjetoEstudoTestes.Controllers;
using ProjetoEstudoTestes.Domain;
using ProjetoEstudoTestes.Domain.Requests.User;
using ProjetoEstudoTestes.Repositories.UsersRepository;

namespace ProjetoEstudoTestes.Business.UserBusiness
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;
        public UserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IResult> CreateUserAsync(UserCreateRequest userRequest)
        {
            var list = await _userRepository.UsersListAsync();

            if (list.Any(c => c.Email.Equals(userRequest.email, StringComparison.OrdinalIgnoreCase)))
            {
                return Results.BadRequest("Usuário já cadastrado");
            }

            Users user = new Users(userRequest.userName, userRequest.password, Guid.NewGuid(), userRequest.email, userRequest.phone);

            if (!user.IsValid)
            {
                return Results.ValidationProblem(user.Notifications.ConvertToProblemDetails());
            }

            await _userRepository.NewUserAsync(user);
            return Results.Ok(user.Id);
        }

        public async Task<IResult> ListBooksCreatedByUserAsync(Guid id)
        {
            var result = await _userRepository.ListBooksCreatedByUserAsync(id);
            return Results.Ok(result);
        }

        public async Task<IResult> ListUsersAsync()
        {
            var list = await _userRepository.UsersListAsync();

            if (list is null)
            {
                return Results.NotFound("Não foram encontrados usuários");
            }

            return Results.Ok(list);
        }
    }
}
