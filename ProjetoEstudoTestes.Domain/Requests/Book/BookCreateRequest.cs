namespace ProjetoEstudoTestes.Domain.Requests.Book
{
    public record BookCreateRequest(string title, Guid userId, string isbnCode, string author, int year, int copies);
}
