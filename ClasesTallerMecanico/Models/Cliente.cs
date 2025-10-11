using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    [Table("Cliente")] // Necesario para TPT
    public class Cliente : Persona
    {
        [Required]
        public string CuilCuit { get; set; } // Not Null
        public string CondFiscal { get; set; }

        // Relación con Usuario (N:1) - La FK está en Usuario para el Creador, pero Cliente tiene otras relaciones
        // Relación con Maquina (1:N)
        public ICollection<Maquina> Maquinas { get; set; } = new List<Maquina>();

        // Relación con Turno (1:N)
        public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    }
}
