using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class comidaNegocio
    {
        private comidaDatos datos = new comidaDatos();

        public List<Comida> listarComida()
        {
            return datos.listarComida();
        }

        public void agregarComida(Comida comida)
        {
            if (string.IsNullOrWhiteSpace(comida.Nombre))
                throw new Exception("El nombre de la comida es obligatorio.");

            if (comida.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            var lista = datos.listarComida();
            if (lista.Any(x => x.Nombre.ToLower() == comida.Nombre.ToLower()))
                throw new Exception("Ya existe una comida con ese nombre.");

            datos.agregarComida(comida);
        }

        public void editarComida(Comida comida)
        {
            datos.editarComida(comida);
        }

        public void eliminarComida(int comidaId)
        {
            datos.eliminarComida(comidaId);
        }

        public Comida obtenerComidaPorId(int comidaId)
        {
            return datos.obtenerComidaPorId(comidaId) ;
        }
    }
}
