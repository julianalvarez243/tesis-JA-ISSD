using capaEntidad;
using capaNegocio;
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
    public partial class ListadoUsuarios : Form
    {
        private usuarioNegocio negocio = new usuarioNegocio();
        private Usuario usuarioActual;
        public ListadoUsuarios(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
        }

        private void cargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            var usuarios = negocio.obtenerUsuarios().OrderBy(item => item.Rol);

            foreach (var u in usuarios)
            {
                dgvUsuarios.Rows.Add(u.UsuarioId, u.NombreUsuario, u.Contrasenia, u.Rol);
            }
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionInformes informes = new GestionInformes(usuarioActual);
            informes.WindowState = FormWindowState.Maximized;
            informes.Show();
        }
    }
}
