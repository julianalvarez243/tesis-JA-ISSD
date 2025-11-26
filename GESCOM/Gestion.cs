using capaEntidad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Gestion : Form
    {
        private Usuario usuarioActual;

        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> shadowPanelsOriginalRects = new();
        private Dictionary<Control, Rectangle> controlsOriginalRects = new();
        private Dictionary<Control, float> originalFonts = new();

        public Gestion(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;

            labelNombreUsuario.Text = $"{usuarioActual.NombreUsuario}";

            if (usuarioActual.Rol == "Mozo")
            {
                btnUsuarios.Enabled = false;
                btnGenerarInformeDiario.Enabled = false;
                btnGenerarInformeMensual.Enabled = false;
            }

            InitializeResponsiveLayout();

            AdjustLayout();

            this.Resize += Gestion_Resize;
        }

        #region Responsive Layout

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
            float scale = Math.Min(scaleX, scaleY);


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

                    if (originalFonts.ContainsKey(ctrl))
                    {
                        float newSize = originalFonts[ctrl] * scale;

                        // 🔥 PREVENCIÓN DE ERROR
                        if (newSize < 1f)
                            newSize = 1f; // tamaño mínimo permitido

                        ctrl.Font = new Font(ctrl.Font.FontFamily, newSize, ctrl.Font.Style);
                    }
                }
            }
        }

        private void Gestion_Resize(object sender, EventArgs e)
        {
            AdjustLayout();
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionMenu gestor = new GestionMenu(usuarioActual);
            gestor.WindowState = FormWindowState.Maximized;
            gestor.Show();
        }


        private void btnComandas_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeComandas gestor = new GestionDeComandas(usuarioActual);
            gestor.WindowState = FormWindowState.Maximized;
            gestor.Show();
        }

        private void generarInformeCajaDia_Click(object sender, EventArgs e)
        {
            using (InformeCajaDia caja = new InformeCajaDia(usuarioActual))
            {
                if (caja.ShowDialog(this) == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void generarInformeCajaMes_Click(object sender, EventArgs e)
        {
            using (InformeCajaMes caja = new InformeCajaMes(usuarioActual))
            {
                if (caja.ShowDialog(this) == DialogResult.OK)
                {
                    return;
                }
            }
        }
        #endregion
    }
}
