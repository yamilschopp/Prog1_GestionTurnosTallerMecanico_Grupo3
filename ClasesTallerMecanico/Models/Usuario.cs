using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    [Table("Usuario")] // Necesario para TPT: especifica la tabla del tipo derivado
    public class Usuario : Persona
    {
        public string CuilCuit { get; set; }
        public string Apellido { get; set; }

        [Required]
        public string Dni { get; set; } // Not Null

        // FK hacia Rol
        public int IdRol { get; set; } // FK - Not Null
        [ForeignKey("IdRol")]
        public Rol Rol { get; set; } // Propiedad de Navegación (1:N)

        [Required]
        public string Contrasena { get; set; } // Not Null

        // Relación con Cliente (1:N)
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}
