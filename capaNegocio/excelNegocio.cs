using capaEntidad;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class excelNegocio
    {
        public void GenerarInforme(List<MovimientoCaja> lista, string nombreArchivo)
        {
            ExcelPackage.License.SetNonCommercialPersonal("julian alvarez");

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                         + "\\" + nombreArchivo + ".xlsx";

            using (var package = new ExcelPackage())
            {
                var hoja = package.Workbook.Worksheets.Add("Movimientos");

                hoja.Cells[1, 1].Value = "ID Movimiento";
                hoja.Cells[1, 2].Value = "Fecha";
                hoja.Cells[1, 3].Value = "Tipo";
                hoja.Cells[1, 4].Value = "Monto";
                hoja.Cells[1, 5].Value = "Usuario";
                hoja.Cells[1, 6].Value = "Descripción";

                int fila = 2;
                foreach (var m in lista)
                {
                    hoja.Cells[fila, 1].Value = m.MovimientoCajaId;
                    hoja.Cells[fila, 2].Value = m.Fecha.ToString("dd/MM/yyyy HH:mm");
                    hoja.Cells[fila, 3].Value = m.Tipo;
                    hoja.Cells[fila, 4].Value = m.Monto;
                    hoja.Cells[fila, 5].Value = m.UsuarioId;
                    hoja.Cells[fila, 6].Value = m.Descripcion;
                    fila++;
                }

                hoja.Cells.AutoFitColumns();

                File.WriteAllBytes(ruta, package.GetAsByteArray());
            }
        }
    }
}
