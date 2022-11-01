using System.ComponentModel.DataAnnotations;

namespace Entitty.BOL.Modelos
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        public string Nombre { get; set; }
    }
}