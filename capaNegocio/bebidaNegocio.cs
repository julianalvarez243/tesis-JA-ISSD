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

        private void validarBebida(Bebida bebida)
        {
            if (bebida == null)
                throw new Exception("Bebida inválida.");

            if (string.IsNullOrWhiteSpace(bebida.Nombre))
                throw new Exception("El nombre de la bebida es obligatorio.");

            if (bebida.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            if (Decimal.Round(bebida.Precio, 2) != bebida.Precio)
                throw new Exception("El precio solo puede tener hasta 2 decimales.");

            string soloNumeros = bebida.Precio.ToString().Replace(",", "").Replace(".", "");
            if (soloNumeros.Length > 10)
                throw new Exception("El precio no puede superar los 10 dígitos.");
        }


        public void agregarBebida(Bebida bebida)
        {
            validarBebida(bebida);

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
