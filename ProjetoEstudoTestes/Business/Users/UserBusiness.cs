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
        public async Task<IResult> ListUsersAsync()
        {
            var list =  await _userRepository.UsersListAsync();

            if (list is null)
            {
                return Results.NotFound("Não foram encontrados usuários");
            }

            return Results.Ok(list);
        }
    }
}
