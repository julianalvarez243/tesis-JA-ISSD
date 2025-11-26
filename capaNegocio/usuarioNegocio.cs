using capaDatos;
using capaEF;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class usuarioNegocio
    { 
       private usuarioDatos datos = new usuarioDatos();

        public List<Usuario> obtenerUsuarios()
        {
            return datos.listarUsuarios();
        }

        public bool CrearUsuario(string nombreUsuario, string contrasenia, string confirmarContrasenia, string rolSeleccionado, out string mensaje)
        {
            return datos.CrearUsuario(nombreUsuario, contrasenia, confirmarContrasenia, rolSeleccionado, out mensaje);
        }

        public void actualizarCantidadComandas(int usuarioId, int cantidad)
        {
            datos.actualizarCantidadComandas(usuarioId, cantidad);
        }


        public Usuario ObtenerUsuarioPorId(int id)
        {
            return datos.ObtenerUsuarioPorId(id);
        }

        public bool EditarUsuario(int id, string nombreUsuario, string contrasenia, string confirmarContrasenia, string rolSeleccionado, out string mensaje)
        {
           return datos.EditarUsuario(id, nombreUsuario, contrasenia, confirmarContrasenia, rolSeleccionado, out mensaje);
        }

        public bool EliminarUsuario(int id, out string mensaje)
        {
            return datos.EliminarUsuario(id, out mensaje);
        }

    }
}
