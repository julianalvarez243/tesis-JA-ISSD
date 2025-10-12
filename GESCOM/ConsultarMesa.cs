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
    public partial class ConsultarMesa : Form
    {
        private Mesa mesaActual;
        public ConsultarMesa(Mesa mesa)
        {
            InitializeComponent();
            mesaActual = mesa;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarMesa_Load(object sender, EventArgs e)
        {
            txtNroMesa.Text = mesaActual.NumeroMesa.ToString();
            txtCapacidad.Text = mesaActual.Tamanio.ToString();
            txtUbicacion.Text = mesaActual.Ubicacion.ToString();
            txtEstado.Text = mesaActual.Estado.ToString();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;

        }
    }
}
