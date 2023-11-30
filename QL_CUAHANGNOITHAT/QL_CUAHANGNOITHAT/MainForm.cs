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
    public partial class MainForm : Form
    {
        int MainPN_ID = 1;
        IDPanel IDMainPN = new IDPanel();    
        static MainForm Main;
        public static MainForm Instance
        {
            get
            {
                if (Main == null)
                {
                    Main = new MainForm();
                }
                return Main;
            }
        }
        public Panel mainpn { get { return MainPN; } set { MainPN = value; } }
        public int MainPN_id { get { return MainPN_ID; } set { MainPN_ID = value;} }
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPN_load();
        }
        private void MainPN_load()
        {
            switch (MainPN_ID)
            {
                case 1:
                    {
                        MainPN.Controls.Clear();
                        Control Sanpham_1 = new GUISanPham();                    
                        MainPN.Controls.Add(Sanpham_1);
                    } break;
                case 2:
                    {
                        MainPN.Controls.Clear();
                        Control Khachhang_2 = new GUIKhachHang();
                        MainPN.Controls.Add(Khachhang_2);
                    } break;
                case 3:
                    {
                        MainPN.Controls.Clear();
                        Control HoaDon_3 = new GUIHoaDon();
                        MainPN.Controls.Add(HoaDon_3);
                    } break;
                case 4:
                    {
                        MainPN.Controls.Clear();
                        Control EmployeeUser_4 = new GUIEmployeeUser();
                        
                        MainPN.Controls.Add(EmployeeUser_4);
                    } break;
                case 5:
                    {
                        MainPN.Controls.Clear();
                        Control DoanhThu_3 = new GUIDoanhThu();
                        MainPN.Controls.Add(DoanhThu_3);
                    } break;
                default:
                    break;
            }
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            MainPN_ID = IDMainPN.IDSanPham;
            MainPN_load();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            MainPN_ID = IDMainPN.IDKhachHang;
            MainPN_load();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            MainPN_ID = IDMainPN.IDHoaDon;
            MainPN_load();
        }

        private void btnEMPUser_Click(object sender, EventArgs e)
        {
            MainPN_ID = IDMainPN.IDEmployeeUser;
            MainPN_load();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            MainPN_ID = IDMainPN.IDDoanhThu;
            MainPN_load();
        }

    }
}
