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
    public partial class PNHoaDon : UserControl
    {
        BLLHoaDon hd = new BLLHoaDon();
        public NhanVien UserAccout { get; set; }
        public PNHoaDon(NhanVien UserAccout)
        {
            this.UserAccout = UserAccout;
            InitializeComponent();
        }

        private void PNHoaDon_Load(object sender, EventArgs e)
        {
            if (UserAccout.MaNhom == "User")
            {
                btnDel.Visible = false;
            }
            dtHoaDon.DataSource = hd.GetHoaDon(""); 
            if(txtMaHD.Text == "")
            {
                tbnShow.Enabled = false;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xoá hoá đơn", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if(hd.deleteHoaDon(txtMaHD.Text))
                {
                    MessageBox.Show("Xoá thành công");
                    dtHoaDon.DataSource = hd.GetHoaDon("");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            else
            {
                return;
            }
        }

        private void dtHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dtHoaDon.SelectedCells[0].RowIndex;
            string selectedValue = dtHoaDon.Rows[selectedRowIndex].Cells[0].Value.ToString();

            HoaDon item = hd.FindHoaDon(selectedValue);
            if (item != null)
            {
                txtMaHD.Text = item.MaHD;
                txtNgayLap.Text = item.NgayLap.ToString();
                txtTenKH.Text = item.KhachHang.HoTen;
                txtTenNhanVien.Text = item.NhanVien.TenNV;
                if(item.TinhTrang == false)
                {
                    rdTTFalse.Checked= true;
                }
                else
                {
                    rdTTTrue.Checked= true;
                }
                txtTongTien.Text = item.TongTien.ToString();
            }

        }

        private void tbnShow_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon fr = new ChiTietHoaDon();
            fr.HD = hd.FindHoaDon(txtMaHD.Text);
            fr.CTHD = hd.GetCTHoaDon(txtMaHD.Text);
            fr.Show();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            tbnShow.Enabled = true;
        }

        private void btnSetTinhTrang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận giao hàng", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (hd.SetTinhTrangHD(txtMaHD.Text))
                {
                    MessageBox.Show("Giao hàng thành công");
                    dtHoaDon.DataSource = hd.GetHoaDon("");
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("Giao Hàng thất bại");
                }
            }
            else
            {
                return;
            }
        }

        private void btnCreateHoaDon_Click(object sender, EventArgs e)
        {
            TaoHoaDon fr = new TaoHoaDon(UserAccout);
            fr.Show();
        }
    }
}
