using ProjetoEstudoTestes.Domain;
namespace ProjetoEstudoTestes.Business.Book
{
    public interface IBookBusiness
    {
        IEnumerable<Books> ListAllBooks();
    }
}
