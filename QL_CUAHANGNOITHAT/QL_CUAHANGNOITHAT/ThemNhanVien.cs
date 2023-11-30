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
    public partial class ThemNhanVien : Form
    {
        BLL_NhanVien nv = new BLL_NhanVien();
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            randomNhanVienID();
            txtUpass.UseSystemPasswordChar = true;
            txtComfirmUpass.UseSystemPasswordChar = true;
        }
        private void randomNhanVienID()
        {
            Random random = new Random();
            string IDNhanVien = "NV" + random.Next(1000, 9999);
            while (nv.checkID(IDNhanVien) == false)
            {
                IDNhanVien = "NV"+random.Next(1000, 9999);
            }
            txtUname.Text =  IDNhanVien;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thêm nhân viên", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (txtComfirmUpass.Text == txtUpass.Text)
                {
                    NhanVien item = new NhanVien();
                    item.MaNV = txtUname.Text;
                    item.TenNV = txtTenNV.Text;
                    item.CCCD = txtCCCD.Text;
                    item.Email = txtEmail.Text;
                    item.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                    item.DienThoai = txtDienThoai.Text;
                    item.MatKhau = txtUpass.Text;
                    item.TinhTrang = "Active";
                    item.MaNhom = "User";

                    if (nv.insertNhanVien(item) == true)
                    {
                        MessageBox.Show("Thêm nhân viên thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                    }
                }
                else
                {
                    if (txtUpass.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu");
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu không trùng khớp");
                    }
                }
            }
            else
            {
                return;
            }           
        }

        
    }
}
