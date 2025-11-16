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
using WinFormsApp2;

namespace capaPresentacion
{
    public partial class InformeCajaDia : Form
    {
        private Usuario usuarioActual;
        private DateTime fechaSeleccionada;
        movimientoCajaNegocio movNeg = new movimientoCajaNegocio();


        public InformeCajaDia(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            fechaSeleccionada = dtpFecha.Value;
            var lista = movNeg.listarPorDia(fechaSeleccionada);


            if (lista.Count == 0)
            {
                MessageBox.Show("No hay movimientos para ese dia.");
                return;
            }

            try
            {
                excelNegocio excelNeg = new excelNegocio();
                excelNeg.GenerarInforme(lista, "Informe_Dia");
                MessageBox.Show("Informe generado y guardado en el escritorio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar informe: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionInformes main = new GestionInformes(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }
    }
}
