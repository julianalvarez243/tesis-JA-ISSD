using capaDatos;
using capaEntidad;
using System.Collections.Generic;

namespace capaNegocio
{
    public class mesaNegocio
    {
        private mesaDatos datos = new mesaDatos();

        public List<Mesa> listarMesas()
        {
            return datos.listarMesas();
        }

        public void agregarMesa(Mesa mesa)
        {
            datos.agregarMesa(mesa);
        }

        public void editarMesa(Mesa mesa)
        {
            datos.editarMesa(mesa);
        }

        public void eliminarMesa(int mesaId)
        {
            datos.eliminarMesa(mesaId);
        }

        public Mesa obtenerMesaPorId(int mesaId)
        {
            return datos.obtenerMesaPorId(mesaId);
        }
    }
}
