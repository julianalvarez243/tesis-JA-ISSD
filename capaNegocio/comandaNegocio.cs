using capaDatos;
using capaEF;
using capaEntidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class comandaNegocio
    {
        private comandaDatos datos = new comandaDatos();
        
        public List<Comanda> listarComandas()
        {
            return datos.listarComandas();
        }

        public void agregarComanda(Comanda comanda)
        {
            if (comanda.MesaId <= 0)
            
                throw new Exception("Debe seleccionar una mesa valida");

            if (comanda.CantComensales == 0)

                throw new Exception("La cantidad de comensales debe ser mayor a 0");
            datos.agregarComanda(comanda);
        }

        public void actualizarComanda(Comanda comanda)
        {
            if (comanda == null)
                throw new Exception("No se recibió la comanda para actualizar.");

            if (comanda.MesaId <= 0)
                throw new Exception("Debe seleccionar una mesa válida.");

            if (comanda.CantComensales <= 0)
                throw new Exception("Debe indicar la cantidad de comensales.");

            if (comanda.Detalles == null || comanda.Detalles.Count == 0)
                throw new Exception("Debe haber al menos un detalle en la comanda.");

            try
            {
                datos.actualizarComanda(comanda);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la comanda en la base de datos: " + ex.Message);
            }
        }

        public Comanda obtenerComandaPorId(int id)
        {
            return datos.obtenerComandaPorId(id);
        }

        public decimal obtenerTotalComanda(int comandaId)
        {
            return datos.obtenerTotalComanda(comandaId);
        }


        public void eliminarComanda(int comandaId)
        {
            if (comandaId <= 0)
                throw new Exception("Comanda inválida.");

            datos.eliminarComanda(comandaId);
        }

    }
}
