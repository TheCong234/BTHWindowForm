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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            string kq = "";
            try
            {
                a = Convert.ToInt32(tbSoA.Text);
                b = Convert.ToInt32(tbSoB.Text);

                if (rdbtCong.Checked)
                {
                    kq = (a + b).ToString();
                }
                else if (rdbtTru.Checked)
                {
                    kq = (a - b).ToString();
                }
                else if (rdbtNhan.Checked)
                {
                    kq = (a * b).ToString();
                }
                else if (rdbtChia.Checked)
                {
                    double c = 1.0 * a / b;
                    kq = c.ToString();
                }
                else
                {
                    kq = (a % b).ToString();
                }
            }
            catch (Exception ex)
            {
                kq = ex.Message;
            }
            finally
            {
                lbKetQua.Text = kq;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbSoA.Text = string.Empty;
            tbSoB.Text = string.Empty;
            lbKetQua.Text = "0";
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
