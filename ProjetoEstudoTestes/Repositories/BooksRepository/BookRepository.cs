using ProjetoEstudoTestes.Context;
using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudoTestes.Repositories.BooksRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Books> ListBooks()
        {
            return _context.books.AsEnumerable();
        }
    }
}
