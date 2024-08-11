﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Users>> UsersListAsync()
        {
            return await _context.users.ToListAsync();
        }
    }
}
