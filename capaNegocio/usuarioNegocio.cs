using capaDatos;
using capaEF;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private bool ValidarContrasenia(string contrasenia, out string mensaje)
        {
            mensaje = "";

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                mensaje = "La contraseña no puede estar vacía.";
                return false;
            }

            string patron = @"^(?=.*\d)(?=.*[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]).{8,}$";

            if (!Regex.IsMatch(contrasenia, patron))
            {
                mensaje = "La contraseña debe tener al menos 8 caracteres, un número y un carácter especial.";
                return false;
            }

            return true;
        }


        public bool CrearUsuario( string nombreUsuario, string contrasenia, string confirmarContrasenia, string rolSeleccionado, out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(rolSeleccionado))
            {
                mensaje = "Debe completar todos los campos.";
                return false;
            }

            if (contrasenia != confirmarContrasenia)
            {
                mensaje = "Las contraseñas no coinciden.";
                return false;
            }

            if (!ValidarContrasenia(contrasenia, out mensaje))
                return false;

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
            if (id <= 0)
            {
                mensaje = "Usuario inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(rolSeleccionado))
            {
                mensaje = "Debe completar todos los campos.";
                return false;
            }

            if (contrasenia != confirmarContrasenia)
            {
                mensaje = "Las contraseñas no coinciden.";
                return false;
            }

            if (!ValidarContrasenia(contrasenia, out mensaje))
                return false;

            return datos.EditarUsuario(id, nombreUsuario, contrasenia, confirmarContrasenia, rolSeleccionado, out mensaje);
        }

        public bool EliminarUsuario(int id, out string mensaje)
        {
            return datos.EliminarUsuario(id, out mensaje);
        }

    }
}
