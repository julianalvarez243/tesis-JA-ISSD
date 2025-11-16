using System.ComponentModel.DataAnnotations;

namespace capaEntidad
{
    public class ComandaDetalle
    {
        public int ComandaDetalleId { get; set; }

        [Required]
        public int ComandaId { get; set; }
        public Comanda Comanda { get; set; }

        public int? ComidaId { get; set; }
        public Comida? Comida { get; set; }

        public int? BebidaId { get; set; }
        public Bebida? Bebida { get; set; }

        [Required]
        public int Cantidad { get; set; }
    }
}
