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
    public partial class ModificarBebida : Form
    {
        private Bebida bebidaSeleccionada;
        private bebidaNegocio negocio = new bebidaNegocio();
        public ModificarBebida(Bebida bebida)
        {
            InitializeComponent();
            bebidaSeleccionada = bebida;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarBebida_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bebidaSeleccionada.Nombre.ToString();
            txtDescripcion.Text = bebidaSeleccionada.Descripcion.ToString();
            txtPrecio.Text = bebidaSeleccionada.Precio.ToString();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                    throw new Exception("El precio debe ser numérico.");

                bebidaSeleccionada.Nombre = txtNombre.Text.Trim();
                bebidaSeleccionada.Descripcion = txtDescripcion.Text.Trim();
                bebidaSeleccionada.Precio = precio;

                negocio.editarBebida(bebidaSeleccionada);

                MessageBox.Show("Bebida actualizada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
