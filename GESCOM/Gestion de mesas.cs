using capaEntidad;
using capaNegocio;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Gestion_de_mesas : Form
    {
        private Usuario usuarioActual;
        private mesaNegocio negocio = new mesaNegocio();

        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> originalRectangles = new();
        private Dictionary<Control, float> originalFontSizes = new();

        public Gestion_de_mesas(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;

            
          
            InitializeResponsiveLayout();
            this.Resize += Gestion_de_mesas_Resize;

        }



        private void Gestion_de_mesas_Resize(object sender, EventArgs e)
        {
            AdjustLayout();
        }
        private void InitializeResponsiveLayout()
        {
            formOriginalSize = this.ClientSize;

            RegisterControl(guna2Panel1);
            RegisterControl(guna2ShadowPanel1);

            foreach (Control ctrl in guna2ShadowPanel1.Controls)
            {
                RegisterControl(ctrl);
            }
        }

        private void RegisterControl(Control ctrl)
        {
            if (!originalRectangles.ContainsKey(ctrl))
            {
                originalRectangles[ctrl] = ctrl.Bounds;
                originalFontSizes[ctrl] = ctrl.Font.Size;
            }
        }

        

        private void AdjustLayout()
        {
            float scaleX = (float)this.ClientSize.Width / formOriginalSize.Width;
            float scaleY = (float)this.ClientSize.Height / formOriginalSize.Height;
            float scale = Math.Min(scaleX, scaleY);

            foreach (var kv in originalRectangles)
            {
                Control ctrl = kv.Key;
                Rectangle original = kv.Value;

                ctrl.Bounds = new Rectangle(
                    (int)(original.X * scaleX),
                    (int)(original.Y * scaleY),
                    (int)(original.Width * scaleX),
                    (int)(original.Height * scaleY)
                );

                if (originalFontSizes.ContainsKey(ctrl))
                {
                    float originalSize = originalFontSizes[ctrl];
                    float newSize = originalSize * scale;

                    if (newSize < 1f) newSize = 1f;

                    ctrl.Font = new Font(ctrl.Font.FontFamily, newSize, ctrl.Font.Style);
                }
            }
        }




        private void cargarMesas()
        {
            mesaNegocio negocio = new mesaNegocio();

            var lista = negocio.listarMesas()
                               .OrderBy(m => m.Tamanio)
                               .ToList();

            dgvMesas.DataSource = lista;

            dgvMesas.Columns["MesaId"].Visible = false;
            dgvMesas.Columns["NumeroMesa"].HeaderText = "Número";
            dgvMesas.Columns["Estado"].HeaderText = "Estado";
            dgvMesas.Columns["Tamanio"].HeaderText = "Capacidad";
            dgvMesas.Columns["Ubicacion"].HeaderText = "Ubicación";

            dgvMesas.AutoResizeColumns();
        }


        private void Gestion_de_mesas_Load(object sender, EventArgs e)
        {
            cargarMesas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion main = new Gestion(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (AgregarMesa frm = new AgregarMesa())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarMesas();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMesas.CurrentRow == null) return;

            var mesaSeleccionada = (Mesa)dgvMesas.CurrentRow.DataBoundItem;

            using (ModificarMesa frm = new ModificarMesa(mesaSeleccionada))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarMesas();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMesas.CurrentRow == null) return;

            var mesaSeleccionada = (Mesa)dgvMesas.CurrentRow.DataBoundItem;

            var result = MessageBox.Show(
                $"¿Está seguro de eliminar la mesa {mesaSeleccionada.NumeroMesa}?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    mesaNegocio negocio = new mesaNegocio();
                    negocio.eliminarMesa(mesaSeleccionada.MesaId);

                    cargarMesas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la mesa: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (dgvMesas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            try
            {
                ExcelPackage.License.SetNonCommercialPersonal("Julian Alvarez");

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Excel (*.xlsx)|*.xlsx";
                save.FileName = "Informe.xlsx";

                if (save.ShowDialog() != DialogResult.OK)
                    return;

                using (ExcelPackage package = new ExcelPackage())
                {
                    var ws = package.Workbook.Worksheets.Add("Datos");

                    for (int col = 0; col < dgvMesas.Columns.Count; col++)
                    {
                        ws.Cells[1, col + 1].Value = dgvMesas.Columns[col].HeaderText;
                        ws.Cells[1, col + 1].Style.Font.Bold = true;
                        ws.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    for (int row = 0; row < dgvMesas.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvMesas.Columns.Count; col++)
                        {
                            ws.Cells[row + 2, col + 1].Value = dgvMesas.Rows[row].Cells[col].Value;
                        }
                    }

                    ws.Cells.AutoFitColumns();

                    File.WriteAllBytes(save.FileName, package.GetAsByteArray());
                }

                MessageBox.Show("Excel generado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }
        }
    }
}