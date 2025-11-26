using capaEntidad;
using capaNegocio;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class GestionUsuarios : Form
    {
        private Usuario usuarioActual;
        private usuarioNegocio usuarioNegocio;

        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> originalControls = new();
        private Dictionary<Control, float> originalFonts = new();

        public GestionUsuarios(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
            usuarioNegocio = new usuarioNegocio();

            InitializeResponsiveLayout();
            this.Resize += GestionUsuarios_Resize;
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }


        private void InitializeResponsiveLayout()
        {
            formOriginalSize = this.ClientSize;

            RegisterControlRecursive(this);
        }

        private void RegisterControlRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                originalControls[c] = c.Bounds;

                if (c.Font != null)
                    originalFonts[c] = c.Font.Size;

                RegisterControlRecursive(c);
            }
        }

        private void GestionUsuarios_Resize(object sender, EventArgs e)
        {
            AdjustControls();
        }

        private void AdjustControls()
        {
            float scaleX = (float)this.ClientSize.Width / formOriginalSize.Width;
            float scaleY = (float)this.ClientSize.Height / formOriginalSize.Height;
            float scale = Math.Min(scaleX, scaleY);

            foreach (var kvp in originalControls)
            {
                Control ctrl = kvp.Key;
                Rectangle orig = kvp.Value;

                ctrl.Bounds = new Rectangle(
                    (int)(orig.X * scaleX),
                    (int)(orig.Y * scaleY),
                    (int)(orig.Width * scaleX),
                    (int)(orig.Height * scaleY)
                );

                if (originalFonts.ContainsKey(ctrl))
                {
                    float newSize = originalFonts[ctrl] * scale;

                    
                    if (newSize < 1f)
                        newSize = 1f; 

                    ctrl.Font = new Font(ctrl.Font.FontFamily, newSize, ctrl.Font.Style);
                }

            }
        }


        private void cargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            var usuarios = usuarioNegocio.obtenerUsuarios();

            foreach (var u in usuarios)
            {
                dgvUsuarios.Rows.Add(u.UsuarioId, u.NombreUsuario, u.Contrasenia, u.Rol, u.CantComandasAtendidas);
            }
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
            using (AgregarUsuario frm = new AgregarUsuario())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarUsuarios();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int UsuarioId = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id"].Value);

                using (ModificarUsuario frm = new ModificarUsuario(UsuarioId))
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        cargarUsuarios();
                    }
                }
            }
            else
            {
                MessageBox.Show("⚠️ Selecciona un usuario primero.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id"].Value);
                string nombreUsuario = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"¿Estás seguro que deseas eliminar al usuario '{nombreUsuario}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    usuarioNegocio negocio = new usuarioNegocio();
                    if (negocio.EliminarUsuario(idUsuario, out string mensaje))
                    {
                        MessageBox.Show("✅ Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("❌ " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("⚠️ Selecciona un usuario primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count == 0)
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

                    for (int col = 0; col < dgvUsuarios.Columns.Count; col++)
                    {
                        ws.Cells[1, col + 1].Value = dgvUsuarios.Columns[col].HeaderText;
                        ws.Cells[1, col + 1].Style.Font.Bold = true;
                        ws.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    for (int row = 0; row < dgvUsuarios.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvUsuarios.Columns.Count; col++)
                        {
                            ws.Cells[row + 2, col + 1].Value = dgvUsuarios.Rows[row].Cells[col].Value;
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
