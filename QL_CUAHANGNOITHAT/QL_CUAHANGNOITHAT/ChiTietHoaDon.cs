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
    public partial class ChiTietHoaDon : Form
    {
        public HoaDon HD { get; set; }
        public object CTHD { get; set; }
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            lbMaHoaDon.Text = HD.MaHD;
            DateTime dateTime = DateTime.Parse( HD.NgayLap.ToString());
            lbNgaylap.Text = dateTime.ToString("dd/MM/yyyy");
            lbTenKH.Text = HD.KhachHang.HoTen;
            dtCHHD.DataSource = CTHD;
            lbTongtien.Text=HD.TongTien.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print fr = new Print(HD);
            fr.ShowDialog();
        }
    }
}
