using Microsoft.EntityFrameworkCore;
using api_mysql_migration.Models;

namespace api_mysql_migration.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Livro> Livros { get; set; }

        public DbSet<UsuarioLivro> UsuarioLivros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioLivro>()
            .HasOne(ul => ul.Usuario)
            .WithMany(u => u.Livros)
            .HasForeignKey(l => l.UsuarioId);
        }
    }
}

