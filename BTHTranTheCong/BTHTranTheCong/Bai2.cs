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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btTinhTong_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(tbNum.Text);
                int sum = 0;
                for(int i = 1; i <= num;i++)
                {
                    sum = ((1 + num) * num)/2;
                }
                lbKetQua.Text = sum.ToString();
            }catch (Exception ex)
            {
                lbKetQua.Text=ex.Message;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            lbKetQua.Text = string.Empty;
            tbNum.Text = string.Empty;
        }

        private void btĐóng_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
