using capaEntidad;
using Microsoft.EntityFrameworkCore;

namespace capaEF
{
    public class GescomDBContext : DbContext
    {
        public DbSet<Comida> Comida { get; set; }
        public DbSet<Bebida> Bebida { get; set; }
        public DbSet<Comanda> Comanda { get; set; }
        public DbSet<EstadoComanda> EstadoComanda { get; set; }
        public DbSet<Mesa> Mesa { get; set; }
        public DbSet<Mozo> Mozo { get; set; }
        public DbSet<Caja> Caja { get; set; }
        public DbSet<EstadoCaja> EstadoCaja { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        // ✅ Constructor vacío obligatorio para migraciones
        public GescomDBContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Cadena de conexión directa para escritorio / migraciones
                optionsBuilder.UseSqlServer(
                    "Server=localhost;Database=GESCOM_DB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
