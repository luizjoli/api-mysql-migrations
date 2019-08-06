using System.Collections.Generic;
using api_mysql_migration.Models;

namespace api_mysql_migration.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<UsuarioLivro> Livros { get; set; }
    }
}

