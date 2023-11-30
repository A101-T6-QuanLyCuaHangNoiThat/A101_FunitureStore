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
    public partial class ThemSanPham : Form
    {
        BLL_SanPham SP = new BLL_SanPham();
        public bool ADD { get; set; }
        public bool EDIT { get; set; }
        public string IDItem { get; set; }
        public ThemSanPham()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ADD == true)
            {
                SanPham item = new SanPham();
                item.MaSP = lbIDSP.Text;
                item.TenSP = txtTenSanPham.Text;
                item.MaNCC =Int32.Parse(cbNhaCC.SelectedValue.ToString());
                item.MoTa = txtMoTa.Text;
                item.MaLoai = Int32.Parse(cbLoaiSP.SelectedValue.ToString());
                item.KichThuoc = txtKichThuoc.Text;
                item.MauSac = txtMauSac.Text;
                item.ChatLieu = txtChatLieu.Text;
                item.XuatXu = txtXuarSu.Text;
                item.DonVi = txtDonVi.Text;
                item.ChuongTrinhApDung = txtCTAP.Text;
                item.XuatXu = txtXuarSu.Text;
                item.GhiChu = txtGhiChu.Text;
                item.SoLuongTon = Int32.Parse(txtSL.Text);

                if (SP.insertSanPham(item) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            if (EDIT == true)
            {
                SanPham item = new SanPham();
                item.MaSP = lbIDSP.Text;
                item.TenSP = txtTenSanPham.Text;
                item.MaNCC = Int32.Parse(cbNhaCC.SelectedValue.ToString());
                item.MoTa = txtMoTa.Text;
                item.MaLoai = Int32.Parse(cbLoaiSP.SelectedValue.ToString());
                item.KichThuoc = txtKichThuoc.Text;
                item.MauSac = txtMauSac.Text;
                item.ChatLieu = txtChatLieu.Text;
                item.XuatXu = txtXuarSu.Text;
                item.DonVi = txtDonVi.Text;
                item.ChuongTrinhApDung = txtCTAP.Text;
                item.XuatXu = txtXuarSu.Text;
                item.GhiChu = txtGhiChu.Text;
                item.SoLuongTon = Int32.Parse(txtSL.Text);

                if (SP.editSanPham(item) == true)
                {
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void ThemSanPham_Load(object sender, EventArgs e)
        {
            cbNhaCC.DataSource = SP.GetNhaCungCap();
            cbNhaCC.DisplayMember = "TenNCC";
            cbNhaCC.ValueMember = "MaNCC";

            cbLoaiSP.DataSource = SP.GetLoaiSanPham();
            cbLoaiSP.DisplayMember = "TenLoai";
            cbLoaiSP.ValueMember = "MaLoai";

            if (EDIT == true)
            {
                lbIDSP.Text = IDItem;
                loadItem();
            }
            if (ADD == true)
            {
                Random random = new Random();
                int IDSP = random.Next(1000000, 9999999); 
                while (SP.checkIDSP(IDSP) == true)
                {
                    IDSP = random.Next(1000000, 9999999);
                }
                lbIDSP.Text = IDSP.ToString();
            }
        }
        void loadItem()
        {
            SanPham item = SP.FindSanPham(IDItem);
            txtTenSanPham.Text = item.TenSP;
            txtMoTa.Text = item.MoTa;
            txtKichThuoc.Text = item.KichThuoc;
            txtMauSac.Text = item.MauSac;
            txtChatLieu.Text = item.ChatLieu;
            txtXuarSu.Text = item.XuatXu;
            txtDonVi.Text = item.DonVi;
            txtCTAP.Text = item.ChuongTrinhApDung;
            txtGhiChu.Text = item.GhiChu;
            txtSL.Text = item.SoLuongTon.ToString();
            cbNhaCC.SelectedValue = item.MaNCC;
            cbNhaCC.Enabled = false;
            cbLoaiSP.SelectedValue = item.MaLoai;
            cbLoaiSP.Enabled = false;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
