using capaEntidad;
using capaNegocio;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class GestionUsuarios : Form
    {
        private Usuario usuarioActual;
        private usuarioNegocio usuarioNegocio;
        public GestionUsuarios(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
            usuarioNegocio = new usuarioNegocio();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionInformes main = new GestionInformes(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            var usuarios = usuarioNegocio.obtenerUsuarios();

            foreach (var u in usuarios)
            {
                dgvUsuarios.Rows.Add(u.UsuarioId, u.NombreUsuario, u.Contrasenia, u.Rol);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (AgregarUsuario frm = new AgregarUsuario())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    // Refrescar DGV después de cerrar la modal
                    cargarUsuarios();
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int UsuarioId = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id"].Value);

                using (ModificarUsuario frm = new ModificarUsuario(UsuarioId))
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        cargarUsuarios(); // Refresca DGV después de editar
                    }
                }
            }
            else
            {
                MessageBox.Show("⚠️ Selecciona un usuario primero.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id"].Value);
                string nombreUsuario = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();

                // Preguntar confirmación
                DialogResult result = MessageBox.Show(
                    $"¿Estás seguro que deseas eliminar al usuario '{nombreUsuario}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    usuarioNegocio negocio = new usuarioNegocio();
                    if (negocio.EliminarUsuario(idUsuario, out string mensaje))
                    {
                        MessageBox.Show("✅ Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarUsuarios(); // Refresca el dgv
                    }
                    else
                    {
                        MessageBox.Show("❌ " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("⚠️ Selecciona un usuario primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
