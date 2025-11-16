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
    public partial class GestionMenu : Form
    {
        private Usuario usuarioActual;
        public GestionMenu(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
        }

        public void cargarComidas()
        {
            comidaNegocio negocio = new comidaNegocio();

            dgvComida.DataSource = negocio.listarComida();
            dgvComida.Columns["ComidaId"].Visible = false;

            dgvComida.AutoResizeColumns();
        }

        public void cargarBebidas()
        {
            bebidaNegocio negocio = new bebidaNegocio();

            dgvBebida.DataSource = negocio.listarBebida();
            dgvBebida.Columns["BebidaId"].Visible = false;

            dgvBebida.AutoResizeColumns();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Gestion main = new Gestion(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();


        }
        private void GestionMenu_Load(object sender, EventArgs e)
        {
            cargarComidas();
            cargarBebidas();

        }

        private void btnAgregarComida_Click(object sender, EventArgs e)
        {
            using (AgregarComida frm = new AgregarComida())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarComidas();
                }
            }
        }

        private void btnEditarComida_Click(object sender, EventArgs e)
        {
            if (dgvComida.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una comida para editar");
            }

            var comidaSeleccionada = (Comida)dgvComida.CurrentRow.DataBoundItem;

            using (ModificarComida frm = new ModificarComida(comidaSeleccionada))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarComidas();
                }
            }
        }

        private void btnEliminarComida_Click(object sender, EventArgs e)
        {
            if (dgvComida.CurrentRow == null) return;

            var comidaSeleccionada = (Comida)dgvComida.CurrentRow.DataBoundItem;

            var resultado = MessageBox.Show(
                 $"¿Está seguro de eliminar la comida '{comidaSeleccionada.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
             );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    comidaNegocio negocio = new comidaNegocio();
                    negocio.eliminarComida(comidaSeleccionada.ComidaId);
                    cargarComidas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la comida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            this.Close();
            Gestion main = new Gestion(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            using (AgregarBebida frm = new AgregarBebida())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarBebidas();
                }
            }
        }

        private void btnEditarBebida_Click(object sender, EventArgs e)
        {
            if (dgvBebida.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una bebida para editar");
            } else
            {
                var bebidaSeleccionada = (Bebida)dgvBebida.CurrentRow.DataBoundItem;

                using (ModificarBebida frm = new ModificarBebida(bebidaSeleccionada))
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        cargarBebidas();
                    }
                }
            }


           
        }

        private void btnEliminarBebida_Click(object sender, EventArgs e)
        {
            if (dgvComida.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una bebida para editar");
            } else
            {
                var bebidaSeleccionada = (Bebida)dgvBebida.CurrentRow.DataBoundItem;

                var resultado = MessageBox.Show(
                     $"¿Está seguro de eliminar la bebida '{bebidaSeleccionada.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                 );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        bebidaNegocio negocio = new bebidaNegocio();
                        negocio.eliminarBebida(bebidaSeleccionada.BebidaId);
                        cargarBebidas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la bebida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
