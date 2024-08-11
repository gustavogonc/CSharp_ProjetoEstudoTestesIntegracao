using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudoTestes.Business.UserBusiness
{
    public interface IUserBusiness
    {
        Task<IResult> ListUsersAsync();
    }
}
