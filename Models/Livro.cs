using System;

namespace api_mysql_migration.Models
{
    public class Livro
    {
         public int Id { get; set; }
        public string Titulo { get; set; }

        public string Editora { get; set; }

        public string Autor { get; set; }

        public DateTime Lancamento { get; set; }
    }
}


