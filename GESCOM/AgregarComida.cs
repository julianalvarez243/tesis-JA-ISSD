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
    public partial class AgregarComida : Form
    {
        private comidaNegocio negocio = new comidaNegocio();
        public AgregarComida()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarComida_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
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
                Comida nuevaComida = new Comida
                {
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precio,
                    Descripcion = txtDescripcion.Text.Trim(),
                };

                negocio.agregarComida(nuevaComida);

                MessageBox.Show("Comida agregada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarComida_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }
    }
}
