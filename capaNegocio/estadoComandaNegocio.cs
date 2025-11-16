using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public  class estadoComandaNegocio
    {
        private estadoComandaDatos datos = new estadoComandaDatos();

        public List<EstadoComanda> listarEstados()
        {
            return datos.listarEstados();
        }
    }
}
