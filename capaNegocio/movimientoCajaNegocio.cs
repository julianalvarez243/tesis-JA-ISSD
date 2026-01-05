using capaEntidad;
using capaDatos;
using System;
using System.Collections.Generic;

namespace capaNegocio
{
    public class movimientoCajaNegocio
    {
        private movimientoCajaDatos datos = new movimientoCajaDatos();

        public List<MovimientoCaja> listar()
        {
            return datos.Listar();
        }

        public int guardarMovimiento(MovimientoCaja movimiento, out string mensaje)
        {
            mensaje = string.Empty;

            if (movimiento.Monto <= 0)
            {
                mensaje = "El monto del movimiento debe ser mayor a cero.";
                return 0;
            }

            if (string.IsNullOrWhiteSpace(movimiento.TipoDePago))
            {
                mensaje = "Debe especificar el tipo de pago.";
                return 0;
            }

            return datos.guardarMovimiento(movimiento, out mensaje);
        }   

        public List<MovimientoCaja> listarPorDia(DateTime fecha)
        {
            return datos.listarPorDia(fecha);
        }

        public List<MovimientoCaja> listarPorMes(int mes, int anio)
        {
            return datos.listarPorMes(mes, anio);
        }
    }
}
