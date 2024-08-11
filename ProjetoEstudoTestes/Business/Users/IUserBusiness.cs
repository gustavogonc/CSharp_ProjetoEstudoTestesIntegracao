using ProjetoEstudoTestes.Domain;
using ProjetoEstudoTestes.Domain.Requests;

namespace ProjetoEstudoTestes.Business.UserBusiness
{
    public interface IUserBusiness
    {
        Task<IResult> ListUsersAsync();
        Task<IResult> CreateUserAsync(UserCreateRequest userRequest);
    }
}
