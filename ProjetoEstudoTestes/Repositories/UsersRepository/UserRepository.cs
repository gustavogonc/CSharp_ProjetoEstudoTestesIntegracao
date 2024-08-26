using Microsoft.EntityFrameworkCore;
using ProjetoEstudoTestes.Context;
using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudoTestes.Repositories.UsersRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context; 
        }

        public async Task<Guid> NewUserAsync(Users user)
        {
            await _context.users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public async Task<IEnumerable<Users>> UsersListAsync()
        {
            return await _context.users.ToListAsync();
        }

        public async Task<Users> ListBooksCreatedByUserAsync(Guid id)
        {
            return await _context.users.Include(b => b.Books)
                                        .FirstOrDefaultAsync(u => u.Id.Equals(id));
        }

        public async Task<Users> UserByIdAsync(Guid id)
        {
            return await _context.users.FirstOrDefaultAsync(u => u.Id.Equals(id));
        }

        public async Task<Users> UpdateUserAsync(Users user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
