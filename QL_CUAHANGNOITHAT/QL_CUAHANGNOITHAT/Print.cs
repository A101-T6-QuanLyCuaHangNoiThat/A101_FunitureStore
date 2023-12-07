using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QL_CUAHANGNOITHAT
{
    public partial class Print : Form
    {
        HoaDon HoaDon;
        BLLHoaDon hd = new BLLHoaDon();
        public Print(HoaDon HoaDon)
        {
            this.HoaDon = HoaDon;
            InitializeComponent();
        }
        
        private void Print_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("rpCTHoaDon", hd.GetCTHoaDonRP(HoaDon.MaHD)));
            DateTime dateTime = DateTime.Parse(HoaDon.NgayLap.ToString());
            string date = dateTime.ToString("dd/MM/yyyy");
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTenKhachHang",HoaDon.KhachHang.HoTen.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pNgayLap",date),
                new Microsoft.Reporting.WinForms.ReportParameter("pMaHoaDon",HoaDon.MaHD.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDiaChi",HoaDon.KhachHang.DiaChi.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSDT",HoaDon.KhachHang.DienThoai.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",HoaDon.TongTien.ToString()),
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }

    }
}
