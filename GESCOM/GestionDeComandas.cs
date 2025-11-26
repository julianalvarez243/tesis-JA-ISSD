using capaDatos;
using capaEntidad;
using capaNegocio;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace capaPresentacion
{
    public partial class GestionDeComandas : Form
    {
        comandaNegocio comandNeg = new comandaNegocio();
        usuarioNegocio usuarioNeg = new usuarioNegocio();
        mesaDatos mesaDatos = new mesaDatos();
        private Usuario usuarioActual;
        private List<Comanda> listaComandas;
        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> shadowPanelsOriginalRects = new();
        private Dictionary<Control, Rectangle> controlsOriginalRects = new();
        private Dictionary<Control, float> originalFonts = new();

        public GestionDeComandas(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;


            InitializeResponsiveLayout();
            AdjustLayout();
            this.Resize += Gestion_Resize;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion main = new Gestion(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void cargarComandas()
        {
            listaComandas = comandNeg.listarComandas();

            dgvComandas.DataSource = listaComandas
                .Select(c => new
                {
                    c.ComandaId,
                    Mesa = c.Mesa.NumeroMesa,
                    Estado = c.EstadoComanda.Descripcion,
                    Comensales = c.CantComensales,
                    Fecha = c.FechaHora
                })
                .ToList();

            dgvComandas.AutoResizeColumns();
            dgvComandas.Columns["ComandaId"].Visible = false;
        }


        private void GestionDeComandas_Load(object sender, EventArgs e)
        {
            cargarComandas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var frm = new AgregarComanda(usuarioActual))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarComandas();
                }
            }

            cargarComandas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvComandas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una comanda para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int comandaId = (int)dgvComandas.CurrentRow.Cells["ComandaId"].Value;



                Comanda comanda = comandNeg.obtenerComandaPorId(comandaId);
                int mesaId = comanda.MesaId;
                Mesa mesa = mesaDatos.obtenerMesaPorId(mesaId);

                if (comanda.EstadoComandaId == 2 || comanda.EstadoComandaId == 3)
                {
                    MessageBox.Show("Esta comanda no puede ser editada porque está finalizada o cancelada.",
                                    "Edición no permitida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    return;
                }


                if (comanda == null)
                {
                    MessageBox.Show("No se pudo cargar la comanda seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (var frm = new ModificarComanda(usuarioActual, comanda))
                    {
                        frm.ShowDialog(this);
                        cargarComandas();
                    }
                    if (comanda.EstadoComandaId == 3)
                    {
                        mesa.Estado = "Disponible";
                        mesaDatos.editarMesa(mesa);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int comandaId = (int)dgvComandas.CurrentRow.Cells["ComandaId"].Value;


            if (dgvComandas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una comanda.", "Aviso");
                return;
            }
            Comanda comanda = comandNeg.obtenerComandaPorId(comandaId);

            if (comanda.EstadoComandaId != 3)
            {
                MessageBox.Show("Solo se pueden eliminar comandas canceladas.", "Aviso");
                return;
            }


            var resultado = MessageBox.Show(
                "¿Está seguro de eliminar la comanda?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                comandNeg.eliminarComanda(comandaId);

                MessageBox.Show("Comanda eliminada.");
                usuarioActual.CantComandasAtendidas -= 1;
                usuarioNeg.actualizarCantidadComandas(usuarioActual.UsuarioId, usuarioActual.CantComandasAtendidas);
                cargarComandas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la comanda: " + ex.Message);
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
        private void dgvComandas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int comandaId = (int)dgvComandas.Rows[e.RowIndex].Cells["ComandaId"].Value;

                Comanda comandaSeleccionada = comandNeg.obtenerComandaPorId(comandaId);

                if (comandaSeleccionada != null)
                {
                    ConsultarComanda frm = new ConsultarComanda(comandaSeleccionada);
                    frm.ShowDialog();
                    cargarComandas();
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la comanda seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (dgvComandas.Rows.Count == 0)
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

                    for (int col = 0; col < dgvComandas.Columns.Count; col++)
                    {
                        ws.Cells[1, col + 1].Value = dgvComandas.Columns[col].HeaderText;
                        ws.Cells[1, col + 1].Style.Font.Bold = true;
                        ws.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }
                        
                    for (int row = 0; row < dgvComandas.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvComandas.Columns.Count; col++)
                        {
                            ws.Cells[row + 2, col + 1].Value = dgvComandas.Rows[row].Cells[col].Value;
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
