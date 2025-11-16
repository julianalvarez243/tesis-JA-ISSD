using capaEntidad;
using capaPresentacion;
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
    public partial class GestionInformes : Form
    {
        private Usuario usuarioActual;
        public GestionInformes(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoUsuarios usuarios = new ListadoUsuarios(usuarioActual);
            usuarios.WindowState = FormWindowState.Maximized;
            usuarios.Show();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoMesas mesas = new ListadoMesas(usuarioActual);
            mesas.WindowState = FormWindowState.Maximized;
            mesas.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoComidas comidas = new ListadoComidas(usuarioActual);
            comidas.WindowState = FormWindowState.Maximized;
            comidas.Show();
        }

        private void generarInformeCajaDia_Click(object sender, EventArgs e)
        {
            InformeCajaDia caja = new InformeCajaDia(usuarioActual);
            caja.WindowState = FormWindowState.Maximized;
            caja.Show();
        }

        private void generarInformeCajaMes_Click(object sender, EventArgs e)
        {
            InformeCajaMes caja = new InformeCajaMes(usuarioActual);
            caja.WindowState = FormWindowState.Maximized;
            caja.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion gestion = new Gestion(usuarioActual);
            gestion.WindowState = FormWindowState.Maximized;
            gestion.Show();
        }
    }
}
