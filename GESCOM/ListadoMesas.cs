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
    public partial class ListadoMesas : Form
    {
        private Usuario usuarioActual;
        public ListadoMesas(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
        }
        private void cargarMesas()
        {
            mesaNegocio negocio = new mesaNegocio();

            dgvMesas.DataSource = negocio.listarMesas().OrderBy(item => item.Tamanio).ToList();    

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

        private void ListadoMesas_Load(object sender, EventArgs e)
        {
            cargarMesas();
        }
    }
}
