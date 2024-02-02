using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dominio.Entidades
{
    public class UsuarioAPI
    {
        [Column("codigo")]
        public int Codigo { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; }
    }
}



