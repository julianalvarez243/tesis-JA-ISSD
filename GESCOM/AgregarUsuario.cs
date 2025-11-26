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


namespace capaPresentacion
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();
            string confirmar = txtConfirmarContrasenia.Text.Trim();
            string rolSeleccionado = cboRol.SelectedItem?.ToString() ?? "";

            usuarioNegocio negocio = new usuarioNegocio();

            if (negocio.CrearUsuario(nombreUsuario, contrasenia, confirmar, rolSeleccionado, out string mensaje))
            {
                MessageBox.Show("✅ Usuario creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // para refrescar dgv al volver
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            cboRol.Items.Add("Administrador");
            cboRol.Items.Add("Mozo");
        }
    }
}
