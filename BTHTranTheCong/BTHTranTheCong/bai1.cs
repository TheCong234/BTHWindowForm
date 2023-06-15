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
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void btSoSanh_Click(object sender, EventArgs e)
        {
            try
            {
                int soA = Convert.ToInt32(tbSoA.Text);
                int soB = Convert.ToInt32(tbSoB.Text);
                if (soA > soB)
                {
                    lbKetQua.Text = soA.ToString();
                }
                else if (soB > soA)
                {
                    lbKetQua.Text = soB.ToString();
                }
                else
                    lbKetQua.Text = "Bằng nhau";
            }
            catch (Exception ex)
            {
                lbKetQua.Text = ex.Message;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbSoA.Text = string.Empty;
            tbSoB.Text = string.Empty;
            lbKetQua.Text = string.Empty;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
