using capaEntidad;
using capaNegocio;
using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ModificarMesa : Form
    {
        private mesaNegocio negocio = new mesaNegocio();
        private Mesa mesaActual;

        public ModificarMesa(Mesa mesa)
        {
            InitializeComponent();
            mesaActual = mesa;
        }

        private void ModificarMesa_Load(object sender, EventArgs e)
        {
            txtNroMesa.Text = mesaActual.NumeroMesa.ToString();
            txtCapacidad.Text = mesaActual.Tamanio.ToString();
            txtUbicacion.Text = mesaActual.Ubicacion;

            switch (mesaActual.Estado)
            {
                case "Disponible":
                    Disponible.Checked = true;
                    break;
                case "Reservada":
                    Reservada.Checked = true;
                    break;
                case "No Disponible":
                    noDisponible.Checked = true;
                    break;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
                bool existe = db.Mesa.Any(m => m.NumeroMesa == numeroMesa && m.MesaId != mesaActual.MesaId);
                if (existe)
                {
                    MessageBox.Show("Ya existe otra mesa con ese número.");
                    return;
                }

                var mesa = db.Mesa.Find(mesaActual.MesaId);
                mesa.NumeroMesa = numeroMesa;
                mesa.Tamanio = tamanio;
                mesa.Ubicacion = txtUbicacion.Text.Trim();
                mesa.Estado = estado;

                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
