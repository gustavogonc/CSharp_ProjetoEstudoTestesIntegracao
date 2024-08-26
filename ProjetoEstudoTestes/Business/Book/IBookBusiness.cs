using ProjetoEstudoTestes.Domain;
using ProjetoEstudoTestes.Domain.Requests.Book;
namespace ProjetoEstudoTestes.Business.Book
{
    public interface IBookBusiness
    {
        IEnumerable<Books> ListAllBooks();
        Task<Books> ListBookByIdAsync(Guid id);
        Task<Guid> CreateBookAsync(BookCreateRequest request);
        Task<IResult> UpdateBookAsync(Guid id, BookUpdateRequest request);
    }
}
