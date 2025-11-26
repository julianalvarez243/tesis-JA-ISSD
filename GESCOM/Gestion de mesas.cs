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

        private Size originalFormSize;
        private Dictionary<Control, Rectangle> originalRect = new();
        private Dictionary<Control, float> originalFontSizes = new();

        public Gestion_de_mesas(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;

            SetupResponsive();
            this.Resize += ResizeAll;
        }


        private void SetupResponsive()
        {
            originalFormSize = this.ClientSize;

            RegisterControls(this);
        }

        private void RegisterControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                originalRect[c] = c.Bounds;
                originalFontSizes[c] = c.Font.Size;

                RegisterControls(c);
            }
        }

        private void ResizeAll(object sender, EventArgs e)
        {
            float scaleX = (float)this.ClientSize.Width / originalFormSize.Width;
            float scaleY = (float)this.ClientSize.Height / originalFormSize.Height;

            float scaleFont = Math.Min(scaleX, scaleY);

            foreach (var item in originalRect)
            {
                Control control = item.Key;
                Rectangle rect = item.Value;

                control.Bounds = new Rectangle(
                    (int)(rect.X * scaleX),
                    (int)(rect.Y * scaleY),
                    (int)(rect.Width * scaleX),
                    (int)(rect.Height * scaleY)
                );

                if (originalFontSizes.ContainsKey(control))
                {
                    control.Font = new Font(control.Font.FontFamily,
                                            originalFontSizes[control] * scaleFont,
                                            control.Font.Style);
                }
            }
        }


        private void cargarMesas()
        {
            mesaNegocio negocio = new mesaNegocio();

            dgvMesas.DataSource = negocio.listarMesas();

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

        private void dgvMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var mesaSeleccionada = (Mesa)dgvMesas.Rows[e.RowIndex].DataBoundItem;

            ConsultarMesa frm = new ConsultarMesa(mesaSeleccionada);
            frm.ShowDialog();

            cargarMesas();
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
