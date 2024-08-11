using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudoTestes.Repositories.UsersRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> UsersListAsync();
        Task<Guid> NewUserAsync(Users user);
    }
}
