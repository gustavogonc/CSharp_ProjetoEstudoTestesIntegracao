namespace ProjetoEstudoTestes.Domain.Requests.User
{
    public record UserUpdateRequest(Guid id, string name, string email, string password, Guid? role);
}
