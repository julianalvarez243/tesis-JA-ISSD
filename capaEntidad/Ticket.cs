using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Ticket
    {
        public int TicketId { get; set; }

        [Required]
        public int ComandaId { get; set; }
        public Comanda Comanda { get; set; }

        [Required]
        public int CajaId { get; set; }
        public Caja Caja { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal Total { get; set; }

        public string MedioDePago { get; set; } 
    }
}
