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
            var result = await _bookRepository.BookByIdAsync(id);
            return result is null ? throw new ArgumentNullException("Livro não encontrado pelo id") : result;
        }

        public async Task<Guid> CreateBookAsync(BookCreateRequest request)
        {
            var resultCreated = await _bookRepository.CreateBookAsync(request);
            return resultCreated;
        }

        public async Task<IResult> UpdateBookAsync(Guid id, BookUpdateRequest request)
        {
            if (id != request.id)
            {
                return Results.BadRequest("Os ids precisam ser iguais");
            }

            var oldBook = await _bookRepository.BookByIdAsync(request.id);

            if (oldBook is null)
            {
                return Results.NotFound("Usuário não encontrado");
            }

            oldBook.Author = request.author is null ? oldBook.Author : request.author;
            oldBook.Title = request.title is null ? oldBook.Title : request.title;
            oldBook.IsbnCode = request.isbnCode is null ? oldBook.IsbnCode : request.isbnCode;
            oldBook.PublicationYear = request.year is null ? oldBook.PublicationYear : (int)request.year;
            oldBook.CopiesAvailable = request.copies is null ? oldBook.CopiesAvailable : (int)request.copies;

            var result = await _bookRepository.UpdateBookAsync(oldBook);
            return Results.Ok(result);
        }
    }
}
