using System.ComponentModel.DataAnnotations;

namespace ClasesTallerMecanico.Models
{
    public class Localidad
    {
        [Key]
        public int Id { get; set; } // PK

        [Required]
        public string Nombre { get; set; } // Not Null

        [Required]
        public string CodigoPostal { get; set; } // Not Null

        [Required]
        public string Provincia { get; set; } // Not Null

        // Relación con Persona (1:N)
        public ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}
