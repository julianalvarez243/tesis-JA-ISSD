using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace capaEntidad
{
    public class Comanda
    {
        public int ComandaId { get; set; }

        [Required]
        public int MesaId { get; set; }
        public Mesa Mesa { get; set; }

        [Required]
        public int EstadoComandaId { get; set; }
        public EstadoComanda EstadoComanda { get; set; }

        [Required]
        public int CantComensales { get; set; }

        public string? Comentario { get; set; }

        [Required]
        public DateTime FechaHora { get; set; } = DateTime.Now;

        public List<ComandaDetalle> Detalles { get; set; } = new List<ComandaDetalle>();
    }
}
