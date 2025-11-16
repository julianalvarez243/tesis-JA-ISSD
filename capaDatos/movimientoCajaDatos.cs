using capaEF;
using capaEntidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace capaDatos
{
    public class movimientoCajaDatos
    {
        public List<MovimientoCaja> Listar()
        {
            using (var db = new GescomDBContext())
            {
                return db.MovimientoCaja
                    .Include("Caja")
                    .ToList();
            }
        }

        public int guardarMovimiento(MovimientoCaja movimiento, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                using (var db = new GescomDBContext())
                {
                    db.MovimientoCaja.Add(movimiento);
                    db.SaveChanges();
                    return movimiento.MovimientoCajaId;
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al guardar el movimiento: {ex.Message}";
                return 0;
            }
        }
        public List<MovimientoCaja> listarPorDia(DateTime fecha)
        {
            using (var db = new GescomDBContext())
            {
                return db.MovimientoCaja
                    .Where(m => m.Fecha.Date == fecha.Date)
                    .ToList();
            }
        }


        public List<MovimientoCaja> listarPorMes(int mes, int anio)
        {
            using (var db = new GescomDBContext())
            {
                return db.MovimientoCaja
                        .Where(m => m.Fecha.Month == mes &&
                                    m.Fecha.Year == anio)
                        .ToList();
            }
        }
    }
}
