using capaEF;
using capaEntidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class comandaDatos
    {
        public List<Comanda> listarComandas()
        {
            using (var db = new capaEF.GescomDBContext())
            {
                return db.Comanda
                         .Include(c => c.Mesa)
                         .Include(c => c.EstadoComanda)
                         .Include(c => c.Detalles) 
                             .ThenInclude(d => d.Comida)
                         .Include(c => c.Detalles)
                             .ThenInclude(d => d.Bebida)
                         .ToList();


            }
        }

        public Comanda obtenerComandaPorId(int id)
        {
            using (var db = new GescomDBContext())
            {
                return db.Comanda
                    .Include(c => c.Mesa)
                    .Include(c => c.EstadoComanda)
                    .Include(c => c.Detalles)
                        .ThenInclude(d => d.Comida)
                    .Include(c => c.Detalles)
                        .ThenInclude(d => d.Bebida)
                    .FirstOrDefault(c => c.ComandaId == id);
            }
        }


        public void agregarComanda(Comanda comanda)
        {
            using (var db = new GescomDBContext())
            {
                db.Comanda.Add(comanda);
                db.SaveChanges();
            }
        }

        public void actualizarComanda(Comanda comanda)
        {
            using (var db = new GescomDBContext())
            {
                try
                {
                    var existente = db.Comanda
                        .Include(c => c.Detalles)
                        .FirstOrDefault(c => c.ComandaId == comanda.ComandaId);

                    if (existente == null)
                        throw new Exception("No se encontró la comanda.");

                    var mesaAnterior = db.Mesa.FirstOrDefault(m => m.MesaId == existente.MesaId);
                    var mesaNueva = db.Mesa.FirstOrDefault(m => m.MesaId == comanda.MesaId);

                    if (mesaAnterior != null && mesaNueva != null && mesaAnterior.MesaId != mesaNueva.MesaId)
                    {
                        mesaAnterior.Estado = "Disponible";
                        mesaNueva.Estado = "No disponible";
                    }

                    existente.totalComanda = comanda.totalComanda;
                    existente.MesaId = comanda.MesaId;
                    existente.CantComensales = comanda.CantComensales;
                    existente.Comentario = comanda.Comentario;
                    existente.EstadoComandaId = comanda.EstadoComandaId;
                    existente.TipoDePago = comanda.TipoDePago;
                    db.ComandaDetalle.RemoveRange(existente.Detalles);
                    existente.Detalles = comanda.Detalles;

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar cambios: " + ex.Message);
                }
            }
        }
       
        public decimal obtenerTotalComanda(int comandaId)
        {
            using (var db = new GescomDBContext())
            {
                var comanda = db.Comanda
                    .Include("Detalles.Comida")
                    .Include("Detalles.Bebida")
                    .FirstOrDefault(c => c.ComandaId == comandaId);

                if (comanda == null)
                    return 0;

                decimal total = 0;

                foreach (var d in comanda.Detalles)
                {
                    if (d.Comida != null)
                        total += d.Comida.Precio * d.Cantidad;

                    if (d.Bebida != null)
                        total += d.Bebida.Precio * d.Cantidad;
                }

                return total;
            }
        }
        public void eliminarComanda(int comandaId)
        {
            using (var db = new GescomDBContext())
            {
                var comanda = db.Comanda
                                .Include(c => c.Detalles)
                                .FirstOrDefault(c => c.ComandaId == comandaId); 

                if (comanda != null)
                {
                    db.ComandaDetalle.RemoveRange(comanda.Detalles);
                    db.Comanda.Remove(comanda);
                    db.SaveChanges();
                }
            }
        }
    }
}

