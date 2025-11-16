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
using static System.Collections.Specialized.BitVector32;

namespace WinFormsApp2
{
    public partial class ListadoComidas : Form
    {
        private Usuario usuarioActual;
        private itemMenuNegocio negocio = new itemMenuNegocio();
        public ListadoComidas(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListadoComidas_Load(object sender, EventArgs e)
        {

            dgvMenu.DataSource = negocio.listarMenuCompleto().OrderBy(item => item.Precio).ToList();

            dgvMenu.Columns["Nombre"].HeaderText = "Nombre";
            dgvMenu.Columns["Descripcion"].HeaderText = "Descripción";
            dgvMenu.Columns["Precio"].HeaderText = "Precio";
            dgvMenu.Columns["Tipo"].HeaderText = "Tipo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionInformes informes = new GestionInformes(usuarioActual);
            informes.WindowState = FormWindowState.Maximized;
            informes.Show();
        }
    }
}
