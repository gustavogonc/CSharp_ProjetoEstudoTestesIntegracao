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

        public async Task<IResult> UpdateUserAsync(UserUpdateRequest user)
        {
            var oldUser = await _userRepository.UserByIdAsync(user.id);

            if (oldUser is null)
            {
                return Results.BadRequest("O usuário não foi encontrado");
            }

            oldUser.Email = user.email is null ?oldUser.Email : user.email;
            oldUser.Password = user.password is null ? oldUser.Password : user.password;
            oldUser.Role = user.role is null ? oldUser.Role : (Guid)user.role;

            var updatedUser = _userRepository.UpdateUserAsync(oldUser);

            return Results.Ok(updatedUser);

        }
    }
}
