using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class MovimientoCaja
    {
        public int MovimientoCajaId { get; set; }

        [Required]
        public int ComandaId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [Required]
        public string Tipo { get; set; } // especifica si sale o entra plata en la jaca

        public string? Descripcion { get; set; }

        [Required]
        public int UsuarioId { get; set; }
    }
}


