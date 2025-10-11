using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    public class Insumo
    {
        [Key]
        public int IdInsu { get; set; } // PK

        [Required]
        public string Nombre { get; set; } // Not Null

        [Required]
        public string Marca { get; set; } // Not Null

        public string Descripcion { get; set; }

        // FK hacia Proveedor
        public int IdProveedor { get; set; } // FK - Not Null
        [ForeignKey("IdProveedor")]
        public Proveedor Proveedor { get; set; } // Propiedad de Navegación (N:1)

        [Required]
        public int Stock { get; set; } // Not Null

        [Required]
        public double PrecioCompra { get; set; } // Not Null

        [Required]
        public double PrecioVenta { get; set; } // Not Null

        [Required]
        public bool Activo { get; set; } // Not Null
    }
}
