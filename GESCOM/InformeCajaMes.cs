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
    public partial class InformeCajaMes : Form
    {
        private Usuario usuarioActual;
        private movimientoCajaNegocio movNeg = new movimientoCajaNegocio();
        private int mesSeleccionado;
        private int anioSeleccionado;


        public InformeCajaMes(Usuario user)
        {
            usuarioActual = user;
            InitializeComponent();
            dtpFecha.CustomFormat = "MMMM yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.ShowUpDown = true;
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Gestion main = new Gestion(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
         
            int mes = dtpFecha.Value.Month;
            int anio = dtpFecha.Value.Year;

           
            var lista = movNeg.listarPorMes(mes, anio);


            if (lista.Count == 0)
            {
                MessageBox.Show("No hay movimientos para ese mes.");
                return;
            }

            try
            {
                excelNegocio excelNeg = new excelNegocio();
                excelNeg.GenerarInforme(lista, "Informe_Mes");
                MessageBox.Show("Informe generado y guardado en el escritorio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar informe: " + ex.Message);
            }
        }
    }
}
