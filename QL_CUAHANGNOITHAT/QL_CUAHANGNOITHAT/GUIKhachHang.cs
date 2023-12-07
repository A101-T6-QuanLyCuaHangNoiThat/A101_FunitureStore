using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QL_CUAHANGNOITHAT
{
    public partial class GUIKhachHang : UserControl
    {
        BLL_KhachHang kh = new BLL_KhachHang();
        NhanVien UserAccout { get; set; }
        public GUIKhachHang(NhanVien UserAccout)
        {
            this.UserAccout = UserAccout;
            InitializeComponent();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void GUIKhachHang_Load(object sender, EventArgs e)
        {
            if (UserAccout.MaNhom == "User")
            {
                btnDel.Visible = false;
            }
            dataGridView1.DataSource = kh.GetKhachHang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            string selectedValue = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

            if (kh.FindKhachHang(selectedValue) != null)
            {
                KhachHang item = kh.FindKhachHang(selectedValue);
                txtHoTen.Text = item.HoTen;
                txtEmail.Text = item.Email;
                txtNSinh.Text = item.NgaySinh.ToString();
                txtDiaChi.Text = item.DiaChi;
                txtDienThoai.Text = item.DienThoai;
                if (item.TinhTrang == "Active") radioButton1.Checked = true;
                else radioButton2.Checked = true;
                txtUname.Text = item.MaKH;
                txtUname.UseSystemPasswordChar = true;
                txtUpass.Text = item.MatKhau;
                txtUpass.UseSystemPasswordChar = true;
            }
        }
        int flag = 1;
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtUname.UseSystemPasswordChar = false;
                txtUpass.UseSystemPasswordChar = false;
                flag = 2;
            }
            else {
                txtUname.UseSystemPasswordChar = true;
                txtUpass.UseSystemPasswordChar = true;
                flag = 1;
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (txtfind.Text == "Nhập vào khách hàng cần tìm" || txtfind.Text == "") MessageBox.Show("Chưa nhập sản phẩm cần tìm");
            else
            {
                if (kh.FindKhachHang(txtfind.Text) != null)
                {
                    KhachHang item = kh.FindKhachHang(txtfind.Text);
                    txtHoTen.Text = item.HoTen;
                    txtEmail.Text = item.Email;
                    txtNSinh.Text = item.NgaySinh.ToString();
                    txtDiaChi.Text = item.DiaChi;
                    txtDienThoai.Text = item.DienThoai;
                    if (item.TinhTrang == "Active") radioButton1.Checked = true;
                    else radioButton2.Checked = true;
                    txtUname.Text = item.MaKH;
                    txtUname.UseSystemPasswordChar = true;
                    txtUpass.Text = item.MatKhau;
                    txtUpass.UseSystemPasswordChar = true;
                }
                else
                {
                    MessageBox.Show("Tìm kiếm thất bại");
                }
            }
        }

        private void txtfind_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtfind.Text == "Nhập vào khách hàng cần tìm") txtfind.Text = "";
        }

        private void txtfind_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtfind.Text == "") txtfind.Text = "Nhập vào khách hàng cần tìm";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (kh.DelKhachHang(txtUname.Text) == true)
            {
                MessageBox.Show("Xoá khách hàng thành công");
                dataGridView1.DataSource = kh.GetKhachHang();
            }
            else
            {
                MessageBox.Show("Xoá khách hàng thất bại");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            KhachHang item = new KhachHang();
            item.MaKH = txtUname.Text;
            item.HoTen = txtHoTen.Text;
            item.Email = txtEmail.Text;
            item.NgaySinh = DateTime.Parse(txtNSinh.Text);
            item.DiaChi = txtDiaChi.Text;
            item.DienThoai = txtDienThoai.Text;
            if (radioButton1.Checked)
            {
                item.TinhTrang = "Active";
            }
            else
            {
                item.TinhTrang = "Blocked";
            }

            if (kh.EditKhachHang(item) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dataGridView1.DataSource = kh.GetKhachHang();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }


    }
}
