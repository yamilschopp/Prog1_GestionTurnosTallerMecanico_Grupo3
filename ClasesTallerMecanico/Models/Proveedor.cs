using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    [Table("Proveedor")] // Necesario para TPT
    public class Proveedor : Persona
    {
        [Required]
        public string CuilCuit { get; set; } // Not Null

        [Required]
        public string CodFiscal { get; set; } // Not Null

        // Relación con Insumo (1:N)
        public ICollection<Insumo> Insumos { get; set; } = new List<Insumo>();
    }
}
