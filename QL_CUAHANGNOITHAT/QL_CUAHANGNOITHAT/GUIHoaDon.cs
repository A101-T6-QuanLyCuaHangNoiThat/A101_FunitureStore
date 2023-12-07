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
    public partial class GUIHoaDon : UserControl
    {
        bool flag = false;
        public NhanVien UserAccout { get; set; }
        public GUIHoaDon(NhanVien UserAccout)
        {
            this.UserAccout = UserAccout;
            InitializeComponent();
        }
        void tabClick()
        {
            if (flag == false)
            {
                tabHoaDon.BackColor = Color.White;
                TabPhieuNhap.BackColor = Color.Gray;
                lbTitle.Text = "Hoá đơn";
                label1.ForeColor= Color.Black;
                label2.ForeColor = Color.DimGray;
                PNHoaDon pn = new PNHoaDon(UserAccout);
                pnMain.Controls.Clear();
                pnMain.Controls.Add(pn);
            }
            else
            {
                tabHoaDon.BackColor = Color.Gray;
                TabPhieuNhap.BackColor = Color.White;
                lbTitle.Text = "Phiếu nhập";
                label1.ForeColor = Color.DimGray;
                label2.ForeColor = Color.Black;
                PNPhieuNhap pn = new PNPhieuNhap(UserAccout);
                pnMain.Controls.Clear();
                pnMain.Controls.Add(pn);
            }
        }

        private void tabHoaDon_Click(object sender, EventArgs e)
        {
            flag = false;
            tabClick();
        }

        private void TabPhieuNhap_Click(object sender, EventArgs e)
        {
            flag = true;          
            tabClick();
        }

        private void GUIHoaDon_Load(object sender, EventArgs e)
        {
            if (UserAccout.MaNhom == "User")
            {
                TabPhieuNhap.Visible = false;
                tabClick();
            }
            else
            {
                tabClick();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            flag = false;
            tabClick();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            flag = true;
            tabClick();
        }


    }
}
