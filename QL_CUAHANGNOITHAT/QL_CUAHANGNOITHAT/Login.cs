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
    public partial class Login : Form
    {
        BLL_User user = new BLL_User();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (user.login(txt_Uname.Text, txt_Upass.Text) == true)
            {
                MessageBox.Show("Login thành công");
                MainForm fr = new MainForm();
                fr.UserAccount = user.GetNhanVien();
                fr.FormClosed += new FormClosedEventHandler(fr_formclosed);
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login thất bại !!!!");
            }
        }

        private void fr_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


    }
}
