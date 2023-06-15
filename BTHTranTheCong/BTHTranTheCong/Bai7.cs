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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void cbCaoVoi_CheckedChanged(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(lbTotal.Text);
            CheckBox cb = (CheckBox)sender;
            //click vào cạo vôi.
            if (cb == cbCaoVoi)
            {
                if (cbCaoVoi.Checked)
                {
                    sum += 100000;
                    lbTotal.Text = sum.ToString();
                }
                else
                {
                    sum -= 100000;
                    lbTotal.Text = sum.ToString();
                }

            }
            //click vào tẩy trắng
            else if (cb == cbTayTrang)
            {
                if (cbTayTrang.Checked)
                {
                    sum += 1200000;
                    lbTotal.Text = sum.ToString();
                }
                else
                {
                    sum -= 1200000;
                    lbTotal.Text = sum.ToString();
                }

            }
            //click vào Chụp hình răng.
            else
            {
                if (cbChupHinh.Checked)
                {
                    sum += 200000;
                    lbTotal.Text = sum.ToString();
                }
                else
                {
                    sum -= 200000;
                    lbTotal.Text = sum.ToString();
                }

            }
        }
        int slCu = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal num = numericUpDown1.Value;
            int slMoi = (int)num;
            if (slCu < slMoi)
            {
                lbTotal.Text = (Convert.ToInt32(lbTotal.Text) + 80000).ToString();
                slCu = slMoi;
            }
            else
            {
                lbTotal.Text = (Convert.ToInt32(lbTotal.Text) - 80000).ToString();
                slCu = slMoi;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbTen.Text = string.Empty;
            cbCaoVoi.Checked = false;
            cbTayTrang.Checked = false;
            cbChupHinh.Checked = false;
            numericUpDown1.Value = 0;
            slCu = 0;
            lbTotal.Text = "0";
        }
    }
}
