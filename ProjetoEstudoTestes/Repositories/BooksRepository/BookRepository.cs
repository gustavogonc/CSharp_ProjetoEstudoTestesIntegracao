using Microsoft.EntityFrameworkCore;
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

        public async Task<Books> LitBookByIdAsync(Guid id)
        {
            return await _context.books.FirstOrDefaultAsync(b => b.Id.Equals(id));
        }
    }
}
