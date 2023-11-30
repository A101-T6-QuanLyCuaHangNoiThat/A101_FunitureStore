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
    public partial class GUIEmployeeUser : UserControl
    {
        BLL_NhanVien nv = new BLL_NhanVien();
        public GUIEmployeeUser()
        {
            InitializeComponent();
        }

        private void txtfind_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtfind.Text == "Nhập vào nhân viên cần tìm") txtfind.Text = "";
        }

        private void txtfind_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtfind.Text == "") txtfind.Text = "Nhập vào nhân viên cần tìm";
        }

        private void GUIEmployeeUser_Load(object sender, EventArgs e)
        {
            GuiLoad();
        }
        void GuiLoad()
        {
            dtNhanVien.DataSource = nv.GetNhanVien();
            cbRole.DataSource = nv.GetNhomNguoiDung();
            cbRole.DisplayMember = "TenNhom";
            cbRole.ValueMember = "MaNhom";
        }

        private void dtNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dtNhanVien.SelectedCells[0].RowIndex;
            string selectedValue = dtNhanVien.Rows[selectedRowIndex].Cells[0].Value.ToString();

            NhanVien item = nv.FindNhanVien(selectedValue);
            txtTenNV.Text = item.TenNV;
            txtCCCD.Text = item.CCCD;
            txtNgaySinh.Text = item.NgaySinh.ToString();
            txtEmail.Text = item.Email;
            txtDienThoai.Text = item.DienThoai;
            if (item.TinhTrang == null || item.TinhTrang == "blocked")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }

            txtUname.Text = item.MaNV;
            txtUpass.Text = item.MatKhau;

            cbRole.SelectedValue = item.MaNhom;
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (txtfind.Text == "" || txtfind.Text == "Nhập vào nhân viên cần tìm") MessageBox.Show("Chưa nhập thông tin nhân viên cần tìm");
            else
            {
                if (nv.FindNhanVien(txtfind.Text) != null)
                {
                    NhanVien item = nv.FindNhanVien(txtfind.Text);
                    txtTenNV.Text = item.TenNV;
                    txtCCCD.Text = item.CCCD;
                    txtNgaySinh.Text = item.NgaySinh.ToString();
                    txtEmail.Text = item.Email;
                    txtDienThoai.Text = item.DienThoai;
                    if (item.TinhTrang == null || item.TinhTrang == "blocked")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton1.Checked = true;
                    }

                    txtUname.Text = item.MaNV;
                    txtUpass.Text = item.MatKhau;

                    cbRole.SelectedValue = item.MaNhom;
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NhanVien updateNV = new NhanVien();
            updateNV.MaNV = txtUname.Text;
            updateNV.TenNV = txtTenNV.Text;
            updateNV.CCCD = txtCCCD.Text;
            updateNV.Email = txtEmail.Text;
            updateNV.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
            updateNV.DienThoai = txtDienThoai.Text;
            if (radioButton2.Checked == true)
            {
                updateNV.TinhTrang = "blocked";
            }
            else
            {
                updateNV.TinhTrang = "Active";
            }

            if (nv.updateNhanVien(updateNV) == true)
            {
                MessageBox.Show("Update nhân viên thành công");
                GuiLoad();
            }
            else MessageBox.Show("Update nhân viên thất bại");
        }

        private void btnSetRole_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận set role cho User : "+txtUname.Text+" - role : "+cbRole.SelectedValue, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (nv.SetRoleNhanVien(txtUname.Text, cbRole.SelectedValue.ToString()) == true)
                {
                    MessageBox.Show("Set role thành công");
                    GuiLoad();
                }
                else
                {
                    MessageBox.Show("Set role thất bại");
                }
                
            }
            else
            {
                return;               
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận bạn muốn xoá nhân viên : "+txtUname.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (nv.deleteNhanVien(txtUname.Text) == true)
                {
                    MessageBox.Show("Xoá nhân viên thành công");
                    GuiLoad();
                }
                else
                {
                    MessageBox.Show("Xoá nhân viên thất bại");
                }

            }
            else
            {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemNhanVien fr = new ThemNhanVien();
            fr.FormClosed += new FormClosedEventHandler(ThemNhanVien_Closed);
            fr.Show();
        }
        private void ThemNhanVien_Closed(object sender, FormClosedEventArgs e)
        {
            GuiLoad();
        }
       
    }
}
