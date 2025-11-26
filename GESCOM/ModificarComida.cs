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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace capaPresentacion
{
    public partial class ModificarComida : Form
    {
        private comidaNegocio negocio = new comidaNegocio();
        private Comida comidaSeleccionada;
        public ModificarComida(Comida comida)
        {
            InitializeComponent();
            comidaSeleccionada = comida;
        }

        private void ModificarComida_Load(object sender, EventArgs e)
        {
            txtNombre.Text = comidaSeleccionada.Nombre.ToString();
            txtDescripcion.Text = comidaSeleccionada.Descripcion.ToString();
            txtPrecio.Text = comidaSeleccionada.Precio.ToString();

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

                comidaSeleccionada.Nombre = txtNombre.Text.Trim();
                comidaSeleccionada.Descripcion = txtDescripcion.Text.Trim();
                comidaSeleccionada.Precio = precio;

                negocio.editarComida(comidaSeleccionada);

                MessageBox.Show("Comida actualizada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
