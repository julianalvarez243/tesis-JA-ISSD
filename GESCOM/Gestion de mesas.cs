using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Gestion_de_mesas : Form
    {
        private Usuario usuarioActual;
        private mesaNegocio negocio = new mesaNegocio();

        public Gestion_de_mesas(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
        }

        private void cargarMesas()
        {
            mesaNegocio negocio = new mesaNegocio();

            // Trae todas las mesas
            dgvMesas.DataSource = negocio.listarMesas();

            // Ocultar columnas que no queremos mostrar
            dgvMesas.Columns["MesaId"].Visible = false;

            dgvMesas.Columns["NumeroMesa"].HeaderText = "Número";
            dgvMesas.Columns["Estado"].HeaderText = "Estado";
            dgvMesas.Columns["Tamanio"].HeaderText = "Capacidad";
            dgvMesas.Columns["Ubicacion"].HeaderText = "Ubicación";

            dgvMesas.AutoResizeColumns();
        }




        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionInformes main = new GestionInformes(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (AgregarMesa frm = new AgregarMesa())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarMesas();
                }
            }
        }



        private void Gestion_de_mesas_Load(object sender, EventArgs e)
        {
            cargarMesas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMesas.CurrentRow == null) return;

            var mesaSeleccionada = (Mesa)dgvMesas.CurrentRow.DataBoundItem;

            using (ModificarMesa frm = new ModificarMesa(mesaSeleccionada))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarMesas();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMesas.CurrentRow == null) return;

            var mesaSeleccionada = (Mesa)dgvMesas.CurrentRow.DataBoundItem;

            var resultado = MessageBox.Show(
                $"¿Está seguro de eliminar la mesa {mesaSeleccionada.NumeroMesa}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    mesaNegocio negocio = new mesaNegocio();
                    negocio.eliminarMesa(mesaSeleccionada.MesaId);
                    cargarMesas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la mesa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que no se clickeó el header
            {
                var mesaSeleccionada = (Mesa)dgvMesas.Rows[e.RowIndex].DataBoundItem;

                ConsultarMesa frm = new ConsultarMesa(mesaSeleccionada);
                frm.ShowDialog();

                cargarMesas ();
            }
        }
    }
}
