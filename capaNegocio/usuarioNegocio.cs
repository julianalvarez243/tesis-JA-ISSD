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
            mensaje = "";

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                mensaje = "El nombre de usuario es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                mensaje = "La contraseña es obligatoria.";
                return false;
            }

            if (contrasenia != confirmarContrasenia)
            {
                mensaje = "Las contraseñas no coinciden.";
                return false;
            }

            using (var db = new GescomDBContext())
            {
                // Verificar si ya existe el usuario
                if (db.Usuario.Any(u => u.NombreUsuario == nombreUsuario))
                {
                    mensaje = "Ya existe un usuario con ese nombre.";
                    return false;
                }

                // Crear el usuario
                Usuario nuevo = new Usuario
                {
                    NombreUsuario = nombreUsuario,
                    Contrasenia = contrasenia,
                    Rol = rolSeleccionado
                };

                db.Usuario.Add(nuevo);
                db.SaveChanges();
            }

            return true;
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            using (var db = new GescomDBContext())
            {
                return db.Usuario.FirstOrDefault(u => u.UsuarioId == id);
            }
        }

        public bool EditarUsuario(int id, string nombreUsuario, string contrasenia, string confirmarContrasenia, string rolSeleccionado, out string mensaje)
        {
            mensaje = "";

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                mensaje = "El nombre de usuario es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                mensaje = "La contraseña es obligatoria.";
                return false;
            }

            if (contrasenia != confirmarContrasenia)
            {
                mensaje = "Las contraseñas no coinciden.";
                return false;
            }

            using (var db = new GescomDBContext())
            {
                var usuario = db.Usuario.FirstOrDefault(u => u.UsuarioId == id);
                if (usuario == null)
                {
                    mensaje = "El usuario no existe.";
                    return false;
                }

                // Validar nombre duplicado
                if (db.Usuario.Any(u => u.NombreUsuario == nombreUsuario && u.UsuarioId != id))
                {
                    mensaje = "Ya existe otro usuario con ese nombre.";
                    return false;
                }

                usuario.NombreUsuario = nombreUsuario;
                usuario.Contrasenia = contrasenia;
                usuario.Rol = rolSeleccionado;

                db.SaveChanges();
            }

            return true;
        }

        public bool EliminarUsuario(int id, out string mensaje)
        {
            mensaje = "";

            using (var db = new GescomDBContext())
            {
                var usuario = db.Usuario.FirstOrDefault(u => u.UsuarioId == id);
                if (usuario == null)
                {
                    mensaje = "El usuario no existe.";
                    return false;
                }

                db.Usuario.Remove(usuario);
                db.SaveChanges();
            }

            return true;
        }

    }
}
