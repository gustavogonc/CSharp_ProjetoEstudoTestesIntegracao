using Microsoft.EntityFrameworkCore;
using ProjetoEstudoTestes.Context;
using ProjetoEstudoTestes.Domain;
using ProjetoEstudoTestes.Domain.Requests.Book;

namespace ProjetoEstudoTestes.Repositories.BooksRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateBookAsync(BookCreateRequest request)
        {
            Books book = new Books
            {
                Id = Guid.NewGuid(),
                UserId = request.userId,
                Author = request.author,
                CopiesAvailable = request.copies,
                IsbnCode = request.isbnCode,
                PublicationYear = request.year,
                Title = request.title,
                CreatedOn  = DateTime.Now,
                EditedOn = DateTime.Now,
                CreatedBy = request.userId,
                EditeBy = request.userId,
            };

            await _context.books.AddAsync(book);
            await _context.SaveChangesAsync();

            return book.Id;
        }

        public IEnumerable<Books> ListBooks()
        {
            return _context.books.AsNoTracking().AsEnumerable();
        }

        public async Task<Books> BookByIdAsync(Guid id)
        {
            return await _context.books.FirstOrDefaultAsync(b => b.Id.Equals(id));
        }

        public async Task<Books> UpdateBookAsync(Books book)
        {
            _context.books.Update(book);
            await _context.SaveChangesAsync();

            return book;
        }
    }
}
