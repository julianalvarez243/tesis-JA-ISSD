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
    public partial class ModificarUsuario : Form
    {
        private int _idUsuario;
        private Usuario _usuario;

        public ModificarUsuario(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            usuarioNegocio negocio = new usuarioNegocio();
            _usuario = negocio.ObtenerUsuarioPorId(_idUsuario);

           

            if (_usuario != null)
            {
                txtNombreUsuario.Text = _usuario.NombreUsuario;
                txtContrasenia.Text = _usuario.Contrasenia;
                txtConfirmarContrasenia.Text = _usuario.Contrasenia;

                
                cboRol.Items.Add("Mozo");
                cboRol.Items.Add("Administrador");

                cboRol.SelectedItem = _usuario.Rol; // Seleccionar el rol actual
            }

            this.FormBorderStyle = FormBorderStyle.FixedDialog;    
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text.Trim();
            string pass = txtContrasenia.Text.Trim();
            string confirmar = txtConfirmarContrasenia.Text.Trim();
            string rolSeleccionado = cboRol.SelectedItem != null ? cboRol.SelectedItem.ToString() : string.Empty;

            usuarioNegocio negocio = new usuarioNegocio();
            if (negocio.EditarUsuario(_idUsuario, nombre, pass, confirmar, rolSeleccionado,out string mensaje))
            {
                MessageBox.Show("✅ Usuario actualizado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ " + mensaje);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
