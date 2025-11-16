using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
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

        public ModificarComanda(Usuario user, Comanda comanda)
        {
            InitializeComponent();
            usuarioActual = user;
            comandaActual = comanda;
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

            cboComida.DataSource = comidaNeg.listarComida();
            cboComida.DisplayMember = "Nombre";
            cboComida.ValueMember = "ComidaId";

            cboBebida.DataSource = bebidaNeg.listarBebida();
            cboBebida.DisplayMember = "Nombre";
            cboBebida.ValueMember = "BebidaId";

            cboEstado.DataSource = estadoNeg.listarEstados();
            cboEstado.DisplayMember = "Descripcion";
            cboEstado.ValueMember = "EstadoComandaId";
            cboEstado.SelectedValue = comandaActual.EstadoComandaId;


            txtCantidadComida.Text = "1";
            txtCantidadBebida.Text = "1";
            txtCantComensales.Text = comandaActual.CantComensales.ToString();
            txtComentario.Text = comandaActual.Comentario;

            // 🔸 Cargar detalles
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                comandaActual.MesaId = (int)cboNroMesa.SelectedValue;
                comandaActual.CantComensales = int.Parse(txtCantComensales.Text);
                comandaActual.Comentario = txtComentario.Text;
                comandaActual.EstadoComandaId = (int)cboEstado.SelectedValue;
                comandaActual.Detalles = listaDetalles;

                comandaNeg.actualizarComanda(comandaActual);

                MessageBox.Show("Comanda actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la comanda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
