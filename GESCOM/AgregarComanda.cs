using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Windows.Forms;
using static capaNegocio.movimientoCajaNegocio;

namespace WinFormsApp2
{
    public partial class AgregarComanda : Form
    {
        private Usuario usuarioActual;
        private List<ComandaDetalle> listaDetalles = new List<ComandaDetalle>();
        private mesaNegocio mesaNeg = new mesaNegocio();
        private comidaNegocio comidaNeg = new comidaNegocio();
        private bebidaNegocio bebidaNeg = new bebidaNegocio();
        private comandaNegocio comandaNeg = new comandaNegocio();
        comandaNegocio comNeg = new comandaNegocio();
        movimientoCajaNegocio movNeg = new movimientoCajaNegocio();
        MovimientoCaja movimiento = new MovimientoCaja();

        public AgregarComanda(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion main = new Gestion(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void AgregarComanda_Load(object sender, EventArgs e)
        {
            cboNroMesa.DataSource = mesaNeg.listarMesas().Where(m => m.Estado == "Disponible").ToList();
            cboNroMesa.DisplayMember = "NumeroMesa";
            cboNroMesa.ValueMember = "MesaId";

            cboComida.DataSource = comidaNeg.listarComida();
            cboComida.DisplayMember = "Nombre";
            cboComida.ValueMember = "ComidaId";

            cboBebida.DataSource = bebidaNeg.listarBebida();
            cboBebida.DisplayMember = "Nombre";
            cboBebida.ValueMember = "BebidaId";

            txtCantidadComida.Text = "1";
            txtCantidadBebida.Text = "1";

        }

        private void btnAgregarComida_Click(object sender, EventArgs e)
        {
            if (cboComida.SelectedItem == null) return;
            var comida = (Comida)cboComida.SelectedItem;
            int cantidad = int.Parse(txtCantidadComida.Text);

            listaDetalles.Add(new ComandaDetalle
            {
                ComidaId = comida.ComidaId,
                Cantidad = cantidad
            });

            actualizarLista();
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            if (cboBebida.SelectedItem == null) return;
            var bebida = (Bebida)cboBebida.SelectedItem;
            int cantidad = int.Parse(txtCantidadBebida.Text);

            listaDetalles.Add(new ComandaDetalle
            {
                BebidaId = bebida.BebidaId,
                Cantidad = cantidad
            });

            actualizarLista();
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (lstPedido.SelectedIndex >= 0)
            {
                listaDetalles.RemoveAt(lstPedido.SelectedIndex);
                actualizarLista();
            }
        }

        private void actualizarLista()
        {
            lstPedido.DataSource = null;
            lstPedido.DataSource = listaDetalles
                .Select(d =>
                    d.ComidaId > 0
                        ? $"{comidaNeg.listarComida().First(c => c.ComidaId == d.ComidaId).Nombre} x{d.Cantidad}"
                        : $"{bebidaNeg.listarBebida().First(b => b.BebidaId == d.BebidaId).Nombre} x{d.Cantidad}")
                .ToList();
        }

        private void limpiarCampos()
        {
            lstPedido.DataSource = null;
            cboBebida.SelectedItem = null;
            cboBebida.SelectedItem = null;
            txtCantComensales.Text = "";
            txtCantidadBebida.Text = "1";
            txtCantidadComida.Text = "1";
            txtComentario.Text = "";
            cboNroMesa.DataSource = mesaNeg.listarMesas().Where(m => m.Estado == "Disponible").ToList();
            cboNroMesa.DisplayMember = "NumeroMesa";
            cboNroMesa.ValueMember = "MesaId";

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                if (cboNroMesa.SelectedItem == null || listaDetalles.Count == 0)
                {
                    MessageBox.Show("Debe completar todos los campos");
                    return;
                }

                var mesa = (Mesa)cboNroMesa.SelectedItem;

                foreach (var detalle in listaDetalles)
                {
                    detalle.ComandaDetalleId = 0;
                }

                var comanda = new Comanda
                {
                    MesaId = mesa.MesaId,
                    CantComensales = int.Parse(txtCantComensales.Text),
                    Comentario = txtComentario.Text,
                    EstadoComandaId = 1,
                    FechaHora = DateTime.Now,
                    Detalles = listaDetalles
                };
                
                mesa.Estado = "No disponible";
                comandaNeg.agregarComanda(comanda);
                mesaNeg.editarMesa(mesa);
                int idComanda = comanda.ComandaId;

               

                decimal totalComanda = comNeg.obtenerTotalComanda(idComanda);

                movimiento.ComandaId = idComanda;
                movimiento.Fecha = DateTime.Now;
                movimiento.Tipo = "Ingreso";
                movimiento.Monto = totalComanda;
                movimiento.Descripcion = "Nueva comanda ID: " + idComanda;
                movimiento.UsuarioId = usuarioActual.UsuarioId;

                string mensaje;
                int idMmov = movNeg.guardarMovimiento(movimiento, out mensaje);

                if (idMmov <= 0)
                {
                    MessageBox.Show("No se pudo registrar el movimiento de caja: " + mensaje);
                    return;
                }

                

                MessageBox.Show("Comanda creada y movimiento registrado.");
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la comanda: " + ex.Message);
            }
        }
    }
}
