using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public abstract class Persona
    {
        [Key]
        public int Id { get; set; } // PK

        [Required] // Implica Not Null
        public string Nombre { get; set; }

        [Required] // Implica Not Null
        public string Domicilio { get; set; }

        // FK hacia Localidad
        public int IdLocalidad { get; set; } // FK - Not Null
        [ForeignKey("IdLocalidad")]
        public Localidad Localidad { get; set; } // Propiedad de Navegación (1:N)

        public string Telefono { get; set; } // String es Nullable por defecto
        public string Correo { get; set; }

        [Required]
        public bool Activo { get; set; } // Not Null
    }
}
