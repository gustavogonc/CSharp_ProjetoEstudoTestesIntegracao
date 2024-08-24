using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudoTestes.Repositories.BooksRepository
{
    public interface IBookRepository
    {
        IEnumerable<Books> ListBooks();
        Task<Books> LitBookByIdAsync(Guid id);
    }
}
