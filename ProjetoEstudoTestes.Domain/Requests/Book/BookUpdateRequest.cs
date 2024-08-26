namespace ProjetoEstudoTestes.Domain.Requests.Book
{
    public record BookUpdateRequest(Guid id, string? title, string? isbnCode, string? author, int? year, int? copies);
}
