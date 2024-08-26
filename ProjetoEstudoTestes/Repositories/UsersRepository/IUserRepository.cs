using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudoTestes.Repositories.UsersRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> UsersListAsync();
        Task<Guid> NewUserAsync(Users user);
        Task<Users> ListBooksCreatedByUserAsync(Guid id);
        Task<Users> UpdateUserAsync(Users user);
        Task<Users> UserByIdAsync(Guid id);
    }
}
