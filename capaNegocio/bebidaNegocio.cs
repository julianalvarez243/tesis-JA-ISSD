using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class bebidaNegocio
    {
        private bebidaDatos datos = new bebidaDatos();

        public List<Bebida> listarBebida()
        {
            return datos.listarBebida();
        }

        public void agregarBebida(Bebida bebida)
        {
            if (string.IsNullOrWhiteSpace(bebida.Nombre))
                throw new Exception("El nombre de la bebida es obligatorio.");

            if (bebida.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            var lista = datos.listarBebida();
            if (lista.Any(x => x.Nombre.ToLower() == bebida.Nombre.ToLower()))
                throw new Exception("Ya existe una bebida con ese nombre.");

            datos.agregarBebida(bebida);
        }

        public void editarBebida(Bebida bebida)
        {
            datos.editarBebida(bebida);
        }

        public void eliminarBebida(int bebidaId)
        {
            datos.eliminarBebida(bebidaId);
        }

        public Bebida obtenerBebidaPorId(int bebidaId)
        {
            return datos.obtenerBebidaPorId(bebidaId) ;
        }
    }
}
