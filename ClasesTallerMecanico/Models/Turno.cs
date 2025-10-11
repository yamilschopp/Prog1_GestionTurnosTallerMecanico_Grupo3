using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [Required]
        public string Estado { get; set; } // Not Null

        public string Descripcion { get; set; }
    }
}
