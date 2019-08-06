namespace api_mysql_migration.Models
{
   public class UsuarioLivro
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
    }
}