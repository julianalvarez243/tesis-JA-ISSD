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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsApp2
{
    public partial class GestionDeComandas : Form
    {
        private Usuario usuarioActual;
        private List<Comanda> listaComandas;


        public GestionDeComandas(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion main = new Gestion(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void cargarComandas()
        {
            comandaNegocio negocio = new comandaNegocio();
            listaComandas = negocio.listarComandas();

            dgvComandas.DataSource = listaComandas
                .Select(c => new
                {
                    c.ComandaId,
                    Mesa = c.Mesa.NumeroMesa,
                    Estado = c.EstadoComanda.Descripcion,
                    Comensales = c.CantComensales,
                    Fecha = c.FechaHora
                })
                .ToList();

            dgvComandas.AutoResizeColumns();
            dgvComandas.Columns["ComandaId"].Visible = false;
        }


        private void GestionDeComandas_Load(object sender, EventArgs e)
        {
            cargarComandas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var frm = new AgregarComanda(usuarioActual))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarComandas();
                }
            }

            cargarComandas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvComandas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una comanda para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int comandaId = (int)dgvComandas.CurrentRow.Cells["ComandaId"].Value;
                comandaNegocio negocio = new comandaNegocio();
                Comanda comanda = negocio.obtenerComandaPorId(comandaId);

                if (comanda == null)
                {
                    MessageBox.Show("No se pudo cargar la comanda seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (var frm = new ModificarComanda(usuarioActual, comanda))
                    {
                        frm.ShowDialog(this);
                        cargarComandas();
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComandas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una comanda.", "Aviso");
                return;
            }

            int comandaId = (int)dgvComandas.CurrentRow.Cells["ComandaId"].Value;

            var resultado = MessageBox.Show(
                "¿Está seguro de eliminar la comanda?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                comandaNegocio comNeg = new comandaNegocio();
                movimientoCajaNegocio movNeg = new movimientoCajaNegocio();
                MovimientoCaja movimiento = new MovimientoCaja();
                
                decimal totalComanda = comNeg.obtenerTotalComanda(comandaId);

                movimiento.ComandaId = comandaId;
                movimiento.Fecha = DateTime.Now;
                movimiento.Tipo = "Egreso";
                movimiento.Monto = totalComanda;
                movimiento.Descripcion = "Eliminación de comanda ID: " + comandaId;
                movimiento.UsuarioId = usuarioActual.UsuarioId;

                string mensaje;
                int idMmov = movNeg.guardarMovimiento(movimiento, out mensaje);

                if (idMmov <= 0)
                {
                    MessageBox.Show("No se pudo registrar el movimiento de caja: " + mensaje);
                    return;
                }

                // 3️⃣ ELIMINAR COMANDA
                comNeg.eliminarComanda(comandaId);

                MessageBox.Show("Comanda eliminada y movimiento registrado.");
                cargarComandas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la comanda: " + ex.Message);
            }
        }


        private void dgvComandas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int comandaId = (int)dgvComandas.Rows[e.RowIndex].Cells["ComandaId"].Value;

                comandaNegocio negocio = new comandaNegocio();
                Comanda comandaSeleccionada = negocio.obtenerComandaPorId(comandaId);

                if (comandaSeleccionada != null)
                {
                    ConsultarComanda frm = new ConsultarComanda(comandaSeleccionada);
                    frm.ShowDialog();
                    cargarComandas();
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la comanda seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
