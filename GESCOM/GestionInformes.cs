using capaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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

            labelNombreUsuario.Text = $"{usuarioActual.NombreUsuario}";

            if (usuarioActual.Rol == "Mozo")
            {
                btnUsuarios.Enabled = false;
                btnVerInformeDiario.Enabled = false;
                btnGenerarInformeDiario.Enabled = false;
                btnVerInformeMensual.Enabled = false;
                btnGenerarInformeMensual.Enabled = false;
                btnGenerarDesempenio.Enabled = false;
                btnVerDesempenio.Enabled = false;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionUsuarios gestor = new GestionUsuarios(usuarioActual);
            gestor.WindowState = FormWindowState.Maximized;
            gestor.Show();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_de_mesas gestor = new Gestion_de_mesas(usuarioActual);
            gestor.WindowState = FormWindowState.Maximized;
            gestor.Show();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionMenu gestor = new GestionMenu(usuarioActual);
            gestor.WindowState = FormWindowState.Maximized;
            gestor.Show();
        }

        private void btnNuevaComanda_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarComanda comanda = new AgregarComanda(usuarioActual);
            comanda.WindowState = FormWindowState.Maximized;
            comanda.Show();
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeComandas gestor = new GestionDeComandas(usuarioActual);
            gestor.WindowState = FormWindowState.Maximized;
            gestor.Show();
        }
    }
}
