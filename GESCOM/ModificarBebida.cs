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

namespace capaPresentacion
{
    public partial class ModificarBebida : Form
    {
        private Bebida bebidaSeleccionada;
        private bebidaNegocio negocio = new bebidaNegocio();
        private bool Disponible;
        public ModificarBebida(Bebida bebida)
        {
            InitializeComponent();
            bebidaSeleccionada = bebida;

            cboDisponible.Items.Add("Sí");
            cboDisponible.Items.Add("No");
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
            
            if (bebidaSeleccionada.Disponible)
            {
                cboDisponible.SelectedIndex = 0;
            }
            else
            {
                cboDisponible.SelectedIndex = 1;
            }

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

                if (cboDisponible.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar si la bebida está disponible o no.");
                    return;
                }

                if (cboDisponible.SelectedIndex == 0)
                {
                    Disponible = true;
                }
                else if (cboDisponible.SelectedIndex == 1)
                {
                    Disponible = false;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                    throw new Exception("El precio debe ser numérico.");

                bebidaSeleccionada.Nombre = txtNombre.Text.Trim();
                bebidaSeleccionada.Descripcion = txtDescripcion.Text.Trim();
                bebidaSeleccionada.Precio = precio;
                bebidaSeleccionada.Disponible = Disponible;


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
