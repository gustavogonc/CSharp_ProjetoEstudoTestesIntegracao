using ProjetoEstudoTestes.Domain;
using ProjetoEstudoTestes.Domain.Requests.Book;
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
        public IEnumerable<Books> ListAllBooks()
        {
            var list = _bookRepository.ListBooks();
            return list.Count() == 0 ? throw new ArgumentNullException("Nenhum livro encontrado") : list;
        }

        public async Task<Books> ListBookByIdAsync(Guid id)
        {
            var result = await _bookRepository.LitBookByIdAsync(id);
            return result is null ? throw new ArgumentNullException("Livro não encontrado pelo id") : result;
        }

        public async Task<Guid> CreateBookAsync(BookCreateRequest request)
        {
            var resultCreated = await  _bookRepository.CreateBookAsync(request);
            return resultCreated;
        }
    }
}
