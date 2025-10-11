using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; } // PK

        [Required]
        public string Nombre { get; set; } // Not Null

        [Required]
        public string Tipo { get; set; } // Not Null

        // Relación con Usuario (1:N)
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
