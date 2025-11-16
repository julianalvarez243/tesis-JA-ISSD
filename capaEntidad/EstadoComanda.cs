using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class EstadoComanda
    { 
        public int EstadoComandaId { get; set; }
        [Required]
        public string Descripcion { get; set; }


        public override string ToString()
        {
            return Descripcion;
        }
    }
}
