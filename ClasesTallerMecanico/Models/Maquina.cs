using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    public class Maquina
    {
        [Key]
        public int Id { get; set; } // PK

        [Required]
        public string Nombre { get; set; } // Not Null

        [Required]
        public string Marca { get; set; } // Not Null

        public string Motor { get; set; }
        public string Patente { get; set; }

        // FK hacia Cliente
        public int IdCliente { get; set; } // FK - Not Null
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; } // Propiedad de Navegación (N:1)

        [Required]
        public bool Activo { get; set; } // Not Null
    }
}
