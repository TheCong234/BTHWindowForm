using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTHTranTheCong
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text == ""||txtPass.Text!="admin")
            {
                MessageBox.Show("Sai tài khoản hoạc mật khẩu");
            }
            else
            {
                Bai23.tenDN = txtName.Text;
                this.Close();
            }
        }

        private void tbnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
