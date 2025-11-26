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

        private void validarComida(Comida comida)
        {
            if (comida == null)
                throw new Exception("Comida inválida.");

            if (string.IsNullOrWhiteSpace(comida.Nombre))
                throw new Exception("El nombre de la comida es obligatorio.");

            if (comida.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            if (Decimal.Round(comida.Precio, 2) != comida.Precio)
                throw new Exception("El precio solo puede tener hasta 2 decimales.");

            string soloNumeros = comida.Precio.ToString().Replace(",", "").Replace(".", "");
            if (soloNumeros.Length > 10)
                throw new Exception("El precio no puede superar los 10 dígitos.");
        }

        public void agregarComida(Comida comida)
        {
            validarComida(comida);

            var lista = datos.listarComida();
            if (lista.Any(x => x.Nombre.ToLower() == comida.Nombre.ToLower()))
                throw new Exception("Ya existe una comida con ese nombre.");

            datos.agregarComida(comida);
        }

        public void editarComida(Comida comida)
        {
            validarComida(comida);

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
