namespace ProjetoEstudoTestes.Domain.Requests.User
{
    public record UserCreateRequest(string userName, string password, Guid role, string? email, string? phone) { }
}
