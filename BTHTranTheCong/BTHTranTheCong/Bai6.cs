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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }
        public double result = 0;
        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {
                double answer = Convert.ToDouble(tbCauTraLoi.Text);
                if (answer == result)
                {
                    lbKetQua.ForeColor = Color.Green;
                    lbKetQua.Text = "Kết quả chính xác.";
                }
                else
                {
                    lbKetQua.ForeColor = Color.Red;
                    lbKetQua.Text = "Sai rồi! Kết quả là " + result;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                lbKetQua.Text = ex.Message;
            }
        }

        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int soA = rd.Next(100);
            int soB = rd.Next(100);
            char[] phepToan = { '+', '-', '*', '/' };
            char dau = phepToan[rd.Next(4)];
            if (dau == '+')
            {
                result = soA + soB;
            }
            else if (dau == '-')
            {
                result = soA - soB;
            }
            else if (dau == '*')
            {
                result = soA * soB;
            }
            else
            {
                result = 1.0 * soA / soB;
            }
            //
            lbSoA.Text = soA.ToString();
            lbSoC.Text = soB.ToString();
            lbPhepToan.Text = dau.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Button bt = (Button)sender;
                if (bt.Text.Equals(ptbXoa.Text))
                {
                    string nhap = tbCauTraLoi.Text;
                    nhap = nhap.Remove(nhap.Length - 1);
                    tbCauTraLoi.Text = nhap;
                }
                else
                {
                    tbCauTraLoi.Text += bt.Text;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                lbKetQua.Text = ex.Message;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            lbKetQua.Text = string.Empty;
            lbSoA.Text = "0";
            lbPhepToan.Text = "-";
            lbSoC.Text = "0";
            tbCauTraLoi.Text= string.Empty;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
