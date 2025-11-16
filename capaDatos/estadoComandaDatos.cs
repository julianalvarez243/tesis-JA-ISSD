using capaEF;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class estadoComandaDatos
    {
        public List<EstadoComanda> listarEstados()
        {
            using (var db = new GescomDBContext())
            {
                return db.EstadoComanda.ToList();
            }
        }
    }
}
