using capaEntidad;
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
    public partial class ConsultarComanda : Form
    {
        private Comanda comandaActual;
        public ConsultarComanda(Comanda comanda)
        {
            InitializeComponent();
            comandaActual = comanda;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarComanda_Load(object sender, EventArgs e)
        {
            txtNroComanda.Text = comandaActual.ComandaId.ToString();
            txtNroMesa.Text = comandaActual.Mesa.NumeroMesa.ToString();
            txtEstado.Text = comandaActual.EstadoComanda.ToString();
            txtComentario.Text = comandaActual.Comentario.ToString();
            txtCantComensales.Text = comandaActual.CantComensales.ToString();

            if (comandaActual.Detalles != null && comandaActual.Detalles.Count > 0)
            {
                lstPedido.DataSource = comandaActual.Detalles
                    .Select(d =>
                        d.ComidaId.HasValue
                            ? $"{d.Comida?.Nombre ?? "Comida desconocida"} x{d.Cantidad}"
                            : $"{d.Bebida?.Nombre ?? "Bebida desconocida"} x{d.Cantidad}"
                    ).ToList();
            }
            else
            {
                lstPedido.DataSource = new List<string> { "No hay ítems en esta comanda." };
            }
        }
    }
}
