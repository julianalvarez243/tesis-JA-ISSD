using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Caja
    {
        public int CajaId { get; set; }
        [Required]
        public decimal CantInicial { get; set; }
        [Required]
        public decimal CantFinal { get; set; }
        [Required]
        public int EstadoCajaId { get; set; }
    }
}
