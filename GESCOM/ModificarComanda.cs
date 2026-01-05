using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class ModificarComanda : Form
    {
        private Usuario usuarioActual;
        private Comanda comandaActual;
        private List<ComandaDetalle> listaDetalles = new List<ComandaDetalle>();
        private mesaNegocio mesaNeg = new mesaNegocio();
        private comidaNegocio comidaNeg = new comidaNegocio();
        private bebidaNegocio bebidaNeg = new bebidaNegocio();
        private comandaNegocio comandaNeg = new comandaNegocio();
        private estadoComandaNegocio estadoNeg = new estadoComandaNegocio();
        private decimal totalOriginal;


        public ModificarComanda(Usuario user, Comanda comanda)
        {
            InitializeComponent();
            usuarioActual = user;
            comandaActual = comanda;
            totalOriginal = comanda.totalComanda;
        }

        private void ModificarComanda_Load(object sender, EventArgs e)
        {
            // aca hace q incluya la actual aunque no esta dispo
            var mesas = mesaNeg.listarMesas();
            var mesasParaCombo = mesas
                .Where(m => m.Estado == "Disponible" || m.MesaId == comandaActual.MesaId)
                .ToList();

            cboNroMesa.DataSource = mesasParaCombo;
            cboNroMesa.DisplayMember = "NumeroMesa";
            cboNroMesa.ValueMember = "MesaId";
            cboNroMesa.SelectedValue = comandaActual.MesaId;

            cboComida.DataSource = comidaNeg.listarComidaDisponible();
            cboComida.DisplayMember = "Nombre";
            cboComida.ValueMember = "ComidaId";

            cboBebida.DataSource = bebidaNeg.listarBebidaDisponible();
            cboBebida.DisplayMember = "Nombre";
            cboBebida.ValueMember = "BebidaId";

            cboEstado.DataSource = estadoNeg.listarEstados();
            cboEstado.DisplayMember = "Descripcion";
            cboEstado.ValueMember = "EstadoComandaId";
            cboEstado.SelectedValue = comandaActual.EstadoComandaId;

            

            cboTipoDePago.Items.Add("Efectivo");
            cboTipoDePago.Items.Add("Tarjeta");
            cboTipoDePago.Items.Add("Transferencia");

            if (comandaActual.TipoDePago == "Efectivo")
            {
                cboTipoDePago.SelectedIndex = 0;
            }
            else if (comandaActual.TipoDePago == "Tarjeta")
            {
                cboTipoDePago.SelectedIndex = 1;
            }
            else if (comandaActual.TipoDePago == "Transferencia")
            {
                cboTipoDePago.SelectedIndex = 2;
            }
            
            txtCantComida.Text = "1";
            txtCantBebida.Text = "1";
            txtCantComensales.Text = comandaActual.CantComensales.ToString();
            txtComentario.Text = comandaActual.Comentario;

            listaDetalles = comandaActual.Detalles
                .Select(d => new ComandaDetalle
                {
                    ComandaDetalleId = d.ComandaDetalleId,
                    ComandaId = d.ComandaId,
                    ComidaId = d.ComidaId,
                    BebidaId = d.BebidaId,
                    Cantidad = d.Cantidad
                })
                .ToList();

            actualizarLista();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
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

        private void btnAgregarComida_Click(object sender, EventArgs e)
        {
            if (cboComida.SelectedItem == null) return;
            var comida = (Comida)cboComida.SelectedItem;
            int cantidad = int.Parse(txtCantComida.Text);

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
            int cantidad = int.Parse(txtCantBebida.Text);

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                int estadoAnterior = comandaActual.EstadoComandaId;
                int estadoNuevo = (int)cboEstado.SelectedValue;

                if ((estadoNuevo == 2 || estadoNuevo == 3))
                {
                    DialogResult confirm = MessageBox.Show(
                        "Está por cambiar el estado de la comanda a un estado FINAL (Entregada o Cancelada).\n" +
                        "Después de este cambio NO se podrá volver a modificar ni eliminar.\n\n" +
                        "¿Desea continuar?",
                        "Confirmar cambio de estado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.No)
                    {
                        return;
                    }
                }

                decimal totalNuevo = listaDetalles.Sum(d =>
                    (d.ComidaId > 0 ? comidaNeg.listarComida().First(c => c.ComidaId == d.ComidaId).Precio * d.Cantidad : 0) +
                    (d.BebidaId > 0 ? bebidaNeg.listarBebida().First(b => b.BebidaId == d.BebidaId).Precio * d.Cantidad : 0)
                );

                comandaActual.MesaId = (int)cboNroMesa.SelectedValue;
                comandaActual.CantComensales = int.Parse(txtCantComensales.Text);
                comandaActual.Comentario = txtComentario.Text;
                comandaActual.EstadoComandaId = (int)cboEstado.SelectedValue;
                comandaActual.Detalles = listaDetalles;
                comandaActual.totalComanda = totalNuevo;

                comandaNeg.actualizarComanda(comandaActual);



                if (comandaActual.EstadoComandaId == 3)
                {
                    movimientoCajaNegocio movNeg = new movimientoCajaNegocio();
                    MovimientoCaja movimiento = new MovimientoCaja();
                    int comandaId = comandaActual.ComandaId;

                    movimiento.ComandaId = comandaId;
                    movimiento.Fecha = DateTime.Now;
                    movimiento.Tipo = "Egreso";
                    movimiento.TipoDePago = cboTipoDePago.SelectedItem?.ToString();
                    movimiento.Monto = totalNuevo;
                    movimiento.Descripcion = "Comanda cancelada. ID: " + comandaId;
                    movimiento.UsuarioId = usuarioActual.UsuarioId;

                    string mensaje;
                    int idMmov = movNeg.guardarMovimiento(movimiento, out mensaje);

                    if (idMmov <= 0)
                    {
                        MessageBox.Show("No se pudo registrar el movimiento de caja: " + mensaje);
                        return;
                    }
                }

                if (comandaActual.EstadoComandaId != 3)
                {
                    movimientoCajaNegocio movNeg = new movimientoCajaNegocio();
                    MovimientoCaja movimiento = new MovimientoCaja();

                    movimiento.ComandaId = comandaActual.ComandaId;
                    movimiento.Fecha = DateTime.Now;
                    movimiento.Tipo = "Modificación";
                    movimiento.TipoDePago = cboTipoDePago.SelectedItem?.ToString();
                    movimiento.Monto = totalNuevo;
                    movimiento.Descripcion = $"Modificación de comanda. ID: {comandaActual.ComandaId}";
                    movimiento.UsuarioId = usuarioActual.UsuarioId;

                    string mensaje;
                    movNeg.guardarMovimiento(movimiento, out mensaje);
                }



                MessageBox.Show("Comanda actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la comanda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            actualizarLista();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
