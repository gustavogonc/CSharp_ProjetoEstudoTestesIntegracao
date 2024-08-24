using ProjetoEstudoTestes.Context;

namespace ProjetoEstudoTestes.Repositories.BooksRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable ListBooksAsync()
        {
            return _context.books.AsQueryable();
        }
    }
}
