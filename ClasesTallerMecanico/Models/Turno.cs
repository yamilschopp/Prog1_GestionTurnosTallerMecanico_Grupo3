using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public class Turno
    {
        [Key]
        public int Id { get; set; } // PK

        // FK hacia Cliente
        public int IdCliente { get; set; } // FK - Not Null
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; } // Propiedad de Navegación (N:1)

        // FK hacia Maquina
        public int IdMaquina { get; set; } // FK - Not Null
        [ForeignKey("IdMaquina")]
        public Maquina Maquina { get; set; } // Propiedad de Navegación (N:1)

        [Required]
        public DateTime Fecha { get; set; } // Not Null

        public string DomicilioTrabajo { get; set; }

        public int IdLocalidad { get; set; } // FK - Not Null
        [ForeignKey("IdLocalidad")]

        public Localidad Localidad { get; set; }

        public string Descripcion { get; set; }

        [Required]
        public bool Activo { get; set; } // Not Null
    }
}
