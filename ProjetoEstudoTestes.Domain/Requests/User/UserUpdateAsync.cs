namespace ProjetoEstudoTestes.Domain.Requests.User
{
    public record UserUpdateAsync(Guid id, string name, string email, string password, Guid? role);
}
