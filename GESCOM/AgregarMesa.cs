using capaEntidad;
using capaNegocio;
using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class AgregarMesa : Form
    {
        private mesaNegocio negocio = new mesaNegocio();

        public AgregarMesa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNroMesa.Text, out int numeroMesa) ||
                !int.TryParse(txtCapacidad.Text, out int tamanio) ||
                string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show("Complete correctamente todos los campos.");
                return;
            }

            string estado = Disponible.Checked ? "Disponible" :
                            Reservada.Checked ? "Reservada" :
                            noDisponible.Checked ? "No Disponible" : "";

            if (estado == "")
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            using (var db = new capaEF.GescomDBContext())
            {
                bool existe = db.Mesa.Any(m => m.NumeroMesa == numeroMesa);
                if (existe)
                {
                    MessageBox.Show("Ya existe una mesa con ese número.");
                    return;
                }

                Mesa mesa = new Mesa
                {
                    NumeroMesa = numeroMesa,
                    Tamanio = tamanio,
                    Ubicacion = txtUbicacion.Text.Trim(),
                    Estado = estado
                };

                db.Mesa.Add(mesa);
                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void AgregarMesa_Load(object sender, EventArgs e)
        {

        }
    }
}
