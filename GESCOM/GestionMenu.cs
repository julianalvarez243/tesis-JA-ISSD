using capaEntidad;
using capaNegocio;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class GestionMenu : Form
    {
        private Usuario usuarioActual;
        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> shadowPanelsOriginalRects = new();
        private Dictionary<Control, Rectangle> controlsOriginalRects = new();
        private Dictionary<Control, float> originalFonts = new();
        public GestionMenu(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;

            InitializeResponsiveLayout();
            AdjustLayout();
            this.Resize += Gestion_Resize;
        }

        public void cargarComidas()
        {
            comidaNegocio negocio = new comidaNegocio();

            dgvComida.DataSource = negocio.listarComida();
            dgvComida.Columns["ComidaId"].Visible = false;

            dgvComida.AutoResizeColumns();
        }

        public void cargarBebidas()
        {
            bebidaNegocio negocio = new bebidaNegocio();

            dgvBebida.DataSource = negocio.listarBebida();
            dgvBebida.Columns["BebidaId"].Visible = false;

            dgvBebida.AutoResizeColumns();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Gestion main = new Gestion(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void GestionMenu_Load(object sender, EventArgs e)
        {
            cargarComidas();
            cargarBebidas();
        }


        private void btnAgregarComida_Click(object sender, EventArgs e)
        {
            using (AgregarComida frm = new AgregarComida())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarComidas();
                }
            }
        }

        private void btnEditarComida_Click(object sender, EventArgs e)
        {
            if (dgvComida.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una comida para editar");
            }

            var comidaSeleccionada = (Comida)dgvComida.CurrentRow.DataBoundItem;

            using (ModificarComida frm = new ModificarComida(comidaSeleccionada))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarComidas();
                }
            }
        }

        private void btnEliminarComida_Click(object sender, EventArgs e)
        {
            if (dgvComida.CurrentRow == null) return;

            var comidaSeleccionada = (Comida)dgvComida.CurrentRow.DataBoundItem;

            var resultado = MessageBox.Show(
                 $"¿Está seguro de eliminar la comida '{comidaSeleccionada.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
             );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    comidaNegocio negocio = new comidaNegocio();
                    negocio.eliminarComida(comidaSeleccionada.ComidaId);
                    cargarComidas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la comida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            using (AgregarBebida frm = new AgregarBebida())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarBebidas();
                }
            }
        }

        private void btnEditarBebida_Click(object sender, EventArgs e)
        {
            if (dgvBebida.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una bebida para editar");
            }
            else
            {
                var bebidaSeleccionada = (Bebida)dgvBebida.CurrentRow.DataBoundItem;

                using (ModificarBebida frm = new ModificarBebida(bebidaSeleccionada))
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        cargarBebidas();
                    }
                }
            }
        }

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

                    float newFontSize = originalFonts[ctrl] * Math.Min(scaleX, scaleY);
                    ctrl.Font = new Font(ctrl.Font.FontFamily, newFontSize, ctrl.Font.Style);
                }
            }
        }

        private void Gestion_Resize(object sender, EventArgs e)
        {
            AdjustLayout();
        }



        private void btnEliminarBebida_Click(object sender, EventArgs e)
        {
            if (dgvBebida.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una bebida para editar");
            }
            else
            {
                var bebidaSeleccionada = (Bebida)dgvBebida.CurrentRow.DataBoundItem;

                var resultado = MessageBox.Show(
                     $"¿Está seguro de eliminar la bebida '{bebidaSeleccionada.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                 );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        bebidaNegocio negocio = new bebidaNegocio();
                        negocio.eliminarBebida(bebidaSeleccionada.BebidaId);
                        cargarBebidas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la bebida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnListarComida_Click(object sender, EventArgs e)
        {
            if (dgvComida.Rows.Count == 0)
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

                    for (int col = 0; col < dgvComida.Columns.Count; col++)
                    {
                        ws.Cells[1, col + 1].Value = dgvComida.Columns[col].HeaderText;
                        ws.Cells[1, col + 1].Style.Font.Bold = true;
                        ws.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    for (int row = 0; row < dgvComida.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvComida.Columns.Count; col++)
                        {
                            ws.Cells[row + 2, col + 1].Value = dgvComida.Rows[row].Cells[col].Value;
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

        private void btnListarBebida_Click(object sender, EventArgs e)
        {
            if (dgvBebida.Rows.Count == 0)
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

                    for (int col = 0; col < dgvBebida.Columns.Count; col++)
                    {
                        ws.Cells[1, col + 1].Value = dgvBebida.Columns[col].HeaderText;
                        ws.Cells[1, col + 1].Style.Font.Bold = true;
                        ws.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    for (int row = 0; row < dgvBebida.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvBebida.Columns.Count; col++)
                        {
                            ws.Cells[row + 2, col + 1].Value = dgvBebida.Rows[row].Cells[col].Value;
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
