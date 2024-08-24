using ProjetoEstudoTestes.Domain;
using ProjetoEstudoTestes.Domain.Requests.Book;

namespace ProjetoEstudoTestes.Repositories.BooksRepository
{
    public interface IBookRepository
    {
        IEnumerable<Books> ListBooks();
        Task<Books> LitBookByIdAsync(Guid id);
        Task<Guid> CreateBookAsync(BookCreateRequest request);
    }
}
