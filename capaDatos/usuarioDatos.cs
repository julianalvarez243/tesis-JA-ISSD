using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaEF;

namespace capaDatos
{
    public class usuarioDatos
    {
        public List<Usuario> listarUsuarios()
        {
            using (var db = new GescomDBContext())
            {
                return db.Usuario.ToList();
            }
        }
        public void actualizarCantidadComandas(int usuarioId, int cantidad)
        {
            using (var db = new GescomDBContext())
            {
                var usuario = db.Usuario.Find(usuarioId);
                if (usuario != null)
                {
                    usuario.CantComandasAtendidas = cantidad;
                    db.SaveChanges();
                }
            }
        }

        public bool CrearUsuario(string nombreUsuario, string contrasenia, string confirmarContrasenia, string rolSeleccionado, out string mensaje)
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
                if (db.Usuario.Any(u => u.NombreUsuario == nombreUsuario))
                {
                    mensaje = "Ya existe un usuario con ese nombre.";
                    return false;
                }

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
            try 
            {
                using (var db = new GescomDBContext())
                {
                    return db.Usuario.FirstOrDefault(u => u.UsuarioId == id);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool EditarUsuario(int id, string nombreUsuario, string contrasenia, string confirmarContrasenia, string rolSeleccionado,out string mensaje)
        {
            mensaje = "";

            try 
            {
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
            catch (Exception ex)
            {
                mensaje = "Error al editar el usuario: " + ex.Message;
                return false;
            }
        }

        public bool EliminarUsuario(int id, out string mensaje)
        {
            mensaje = "";

            try 
            {
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
            catch (Exception ex)
            {
                mensaje = "Error al eliminar el usuario: " + ex.Message;
                return false;
            }
        }
    }
}
