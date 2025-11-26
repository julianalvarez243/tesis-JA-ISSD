using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Windows.Forms;
using static capaNegocio.movimientoCajaNegocio;

namespace capaPresentacion
{
    public partial class AgregarComanda : Form
    {
        private Usuario usuarioActual;
        private usuarioNegocio usuarioNegocio = new usuarioNegocio();
        private List<ComandaDetalle> listaDetalles = new List<ComandaDetalle>();
        private mesaNegocio mesaNeg = new mesaNegocio();
        private comidaNegocio comidaNeg = new comidaNegocio();
        private bebidaNegocio bebidaNeg = new bebidaNegocio();
        private comandaNegocio comandaNeg = new comandaNegocio();
        private movimientoCajaNegocio movNeg = new movimientoCajaNegocio();
        private MovimientoCaja movimiento = new MovimientoCaja();
        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> shadowPanelsOriginalRects = new();
        private Dictionary<Control, Rectangle> controlsOriginalRects = new();
        private Dictionary<Control, float> originalFonts = new();

        public AgregarComanda(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            InitializeResponsiveLayout();
            AdjustLayout();
            this.Resize += Gestion_Resize;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
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

            txtCantComida.Text = "1";
            txtCantBebida.Text = "1";

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
            txtCantBebida.Text = "1";
            txtCantComida.Text = "1";
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

                decimal totalComanda = comandaNeg.obtenerTotalComanda(idComanda);

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
                usuarioActual.CantComandasAtendidas+= 1;
                usuarioNegocio.actualizarCantidadComandas(usuarioActual.UsuarioId, usuarioActual.CantComandasAtendidas);
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la comanda: " + ex.Message);
            }
        }

        private void InitializeResponsiveLayout()
        {
            formOriginalSize = this.ClientSize;

            foreach (Control shadow in guna2Panel1.Controls)
            {
                shadowPanelsOriginalRects[shadow] = shadow.Bounds;

                foreach (Control ctrl in shadow.Controls)
                {
                    controlsOriginalRects[ctrl] = ctrl.Bounds;
                    originalFonts[ctrl] = ctrl.Font.Size;
                }
            }
        }

        private void AdjustLayout()
        {
            float scaleX = (float)this.ClientSize.Width / formOriginalSize.Width;
            float scaleY = (float)this.ClientSize.Height / formOriginalSize.Height;

            foreach (Control shadow in guna2Panel1.Controls)
            {
                Rectangle orig = shadowPanelsOriginalRects[shadow];
                shadow.Bounds = new Rectangle(
                    (int)(orig.X * scaleX),
                    (int)(orig.Y * scaleY),
                    (int)(orig.Width * scaleX),
                    (int)(orig.Height * scaleY)
                );

                foreach (Control ctrl in shadow.Controls)
                {
                    Rectangle ctrlOrig = controlsOriginalRects[ctrl];
                    ctrl.Bounds = new Rectangle(
                        (int)(ctrlOrig.X * scaleX),
                        (int)(ctrlOrig.Y * scaleY),
                        (int)(ctrlOrig.Width * scaleX),
                        (int)(ctrlOrig.Height * scaleY)
                    );

                    float newFontSize = originalFonts[ctrl] * Math.Min(scaleX, scaleY);
                    ctrl.Font = new Font(ctrl.Font.FontFamily, newFontSize, ctrl.Font.Style);
                }
            }
        }

        private void Gestion_Resize(object sender, EventArgs e)
        {
            AdjustLayout();
        }
    }
}
