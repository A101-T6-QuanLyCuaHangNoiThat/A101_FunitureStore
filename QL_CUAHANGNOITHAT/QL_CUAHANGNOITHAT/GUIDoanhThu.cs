using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

using BLL;
namespace QL_CUAHANGNOITHAT
{
    public partial class GUIDoanhThu : UserControl
    {
        BLL_DoanhThu dt = new BLL_DoanhThu();
        public GUIDoanhThu()
        {
            InitializeComponent();
        }

        private void GUIDoanhThu_Load(object sender, EventArgs e)
        {
            lbIncome.Text = dt.TongThuNhap().ToString("N");
            lbSpending.Text = dt.TotalSpending().ToString("N");
            lbClient.Text = dt.CountClient().ToString();

            lbDoanhThu.Text = (dt.TongThuNhap() - dt.TotalSpending()).ToString("N") + " VND";
            dtDoanhThu.DataSource = dt.getHoaDon();
        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];
            worksheet.Cells[1, 1] = "DOANH THU CỬA HÀNG";
            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[2, i] = dataGridView.Columns[i - 1].HeaderText;
                worksheet.Cells[2, i].Font.Bold = true;
            }
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }
            worksheet.Cells[dataGridView.Rows.Count + 3, 1] = "Tổng tiền";
            worksheet.Cells[dataGridView.Rows.Count + 3, 4] = lbDoanhThu.Text;
            excelApp.Visible = true;
            ReleaseComObjects(worksheet);
            ReleaseComObjects(workbook);
            ReleaseComObjects(excelApp);
        }

        private void ReleaseComObjects(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnExport_Click(object sender, System.EventArgs e)
        {
            try
            {
                ExportToExcel(dtDoanhThu);
            }
            catch (System.Exception)
            {

                MessageBox.Show("Export thất bại");
            }
        }
    }
}
