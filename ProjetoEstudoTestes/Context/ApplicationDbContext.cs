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
        public DbSet<Books> books {get ; set;} 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Ignore<Notification>();
            builder.Entity<Users>().Property(c => c.Name).HasColumnType("varchar").HasMaxLength(80);
            builder.Entity<Users>().Property(c => c.Email).HasColumnType("varchar").HasMaxLength(100);
            builder.Entity<Users>().Property(c => c.PhoneNumber).HasColumnType("varchar").HasMaxLength(20);
            builder.Entity<Users>().HasMany(u => u.Books)
                                   .WithOne(u => u.User)
                                   .HasForeignKey(u => u.UserId);

            builder.Entity<Books>().Property(c => c.IsbnCode).HasColumnType("varchar").HasMaxLength(30);
            builder.Entity<Books>().Property(c => c.Title).HasColumnType("varchar").HasMaxLength(200);
            builder.Entity<Books>().Property(c => c.Author).HasColumnType("varchar").HasMaxLength(150);
        }
    }
}
