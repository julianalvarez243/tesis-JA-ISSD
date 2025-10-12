using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Mesa
    {
        public int MesaId { get; set; }
        [Required]
        public int NumeroMesa { get; set; }
        public string Estado { get; set; }
        public string Ubicacion { get; set; }
        public int Tamanio { get; set; }
    }
}

