namespace ProjetoEstudoTestes.Domain.Requests
{
    public record UserCreateRequest (string userName, string password, Guid role, string? email, string? phone){}
}
