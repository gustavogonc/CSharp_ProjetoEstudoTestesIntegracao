using ProjetoEstudoTestes.Domain;
using ProjetoEstudoTestes.Repositories.BooksRepository;

namespace ProjetoEstudoTestes.Business.Book
{
    public class BookBusiness : IBookBusiness
    {
        private readonly IBookRepository _bookRepository;
        public BookBusiness(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Books> ListAllBooksAsync()
        {
            var list = _bookRepository.ListBooks();
            return list is null ? throw new ArgumentNullException("Nenhum livro encontrado") : list;
        }
    }
}
