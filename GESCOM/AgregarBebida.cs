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
    public partial class AgregarBebida : Form
    {
        private bebidaNegocio negocio = new bebidaNegocio();
        public AgregarBebida()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string precioTexto = txtPrecio.Text.Trim();

            if (!decimal.TryParse(precioTexto, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }


            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.");
                return;
            }

            if (Decimal.Round(precio, 2) != precio)
            {
                MessageBox.Show("El precio solo puede tener hasta 2 decimales.");
                return;
            }

            string soloNumeros = precioTexto.Replace(",", "").Replace(".", "");
            if (soloNumeros.Length > 10)
            {
                MessageBox.Show("El precio no puede superar los 10 dígitos.");
                return;
            }

            try
            {
                Bebida nuevaBebida = new Bebida
                {
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precio,
                    Descripcion = txtDescripcion.Text.Trim(),
                };

                negocio.agregarBebida(nuevaBebida);

                MessageBox.Show("Bebida agregada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarBebida_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }
    }
}
