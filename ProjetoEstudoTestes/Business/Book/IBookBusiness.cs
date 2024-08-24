using ProjetoEstudoTestes.Domain;
namespace ProjetoEstudoTestes.Business.Book
{
    public interface IBookBusiness
    {
        IEnumerable<Books> ListAllBooks();
        Task<Books> ListBookByIdAsync(Guid id);
    }
}
