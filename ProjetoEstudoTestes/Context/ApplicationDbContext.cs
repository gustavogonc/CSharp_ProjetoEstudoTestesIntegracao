using Microsoft.EntityFrameworkCore;
using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudoTestes.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Users> users {get ; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Ignore<Notification>();
            builder.Entity<Users>().Property(c => c.Name).HasColumnType("varchar").HasMaxLength(80);
            builder.Entity<Users>().Property(c => c.Email).HasColumnType("varchar").HasMaxLength(100);
            builder.Entity<Users>().Property(c => c.PhoneNumber).HasColumnType("varchar").HasMaxLength(20);
        }
    }
}
